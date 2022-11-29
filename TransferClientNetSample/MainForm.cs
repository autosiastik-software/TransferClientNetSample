using Timer = System.Windows.Forms.Timer;

namespace TransferClientNetSample
{
    public partial class MainForm : Form
    {
        private readonly TransferClient _transferClient;
        private readonly Timer _timer;
        private Guid _transferId;

        public MainForm()
        {
            InitializeComponent();

            _transferClient = new TransferClient();

            _timer = new Timer();
            _timer.Interval = 2000;
            _timer.Tick +=_timer_Tick;
        }

        private async void btnQrCode_Click(object sender, EventArgs e)
        {
            var qrCode = await _transferClient.GetQrCode();

            if (qrCode.Item1 != null)
            {
                processBar.Style = ProgressBarStyle.Marquee;
                status.Text = "Warte auf Datei...";
                pictureBox.Image = qrCode.Item1;
                _transferId = qrCode.Item2!.Value;
                _timer.Start();
            }
        }

        private async void _timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            var res = await _transferClient.CheckIfFileExists(_transferId);

            if (!string.IsNullOrEmpty(res))
            {
                status.Text = "Digitalisiere Fahrzeugschein...";
                await ScanFile(res);
            }
            else
            {
                _timer.Start();
            }
        }

        private async Task ScanFile(string fileUrl)
        {
            var res = await _transferClient.ScanFromUrl(fileUrl);
            processBar.Style = ProgressBarStyle.Blocks;
            status.Text = "";
            panelResult.Visible = true;
            plate.Text = $@"Kennzeichen: {res.RegistrationNumber}";
            hsn.Text = $@"HSN: {res.Hsn}";
            tsn.Text = $@"TSN: {res.Tsn}";
            vin.Text = $@"VIN: {res.Vin}";
        }
    }
}
