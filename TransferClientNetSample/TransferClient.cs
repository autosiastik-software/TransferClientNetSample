using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace TransferClientNetSample
{
    internal class TransferClient
    {
        private const string ApiBaseEndpoint = "https://fahrzeugschein-scanner.de";

        public async Task<(Image?, Guid?)> GetQrCode()
        {
            using var client = new HttpClient();
            var url = $"{ApiBaseEndpoint}/api/FileTransfer/GetTransferInfo";
            var message = await client.GetAsync(url);
            var res = await message.Content.ReadAsStringAsync();
            var transfer = JsonConvert.DeserializeObject<TransferInfo>(res);

            if (transfer != null)
            {
                var qrCode = transfer.QrCode.Replace("data:image/png;charset=utf-8;base64, ", "");
                var imageBytes = Convert.FromBase64String(qrCode);
                using var ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                return (Image.FromStream(ms, true), transfer.TransferId);
            }

            return (null, null);
        }

        public async Task<string> CheckIfFileExists(Guid transferId)
        {
            using var client = new HttpClient();
            var url = $"{ApiBaseEndpoint}/api/FileTransfer/TransferExists?transferId={transferId}";
            var message = await client.GetAsync(url);

            if (message.StatusCode == HttpStatusCode.OK)
            {
                var res = await message.Content.ReadAsStringAsync();
                res = JsonConvert.DeserializeObject<string>(res);

                if (res != null)
                {
                    return res;
                }
            }

            return "";
        }

        public async Task<ScanResult> ScanFromUrl(string fileUrl)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("access_key", "your-token");
            var url = "https://api.fahrzeugschein-scanner.de/scan_url_de";
            var content = new 
            {
                url = fileUrl
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(content);
            var payload = new StringContent(json, Encoding.UTF8, "application/json");

            var message = await client.PostAsync(url, payload);

            if (message.StatusCode == HttpStatusCode.OK)
            {
                var res = await message.Content.ReadAsStringAsync();
                var scan = JsonConvert.DeserializeObject<ScanResult>(res);

                if (scan != null)
                {
                    return scan;
                }
            }

            return new ScanResult();
        }
    }
}
