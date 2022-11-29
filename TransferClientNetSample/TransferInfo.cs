namespace TransferClientNetSample
{
    internal class TransferInfo
    {
        /// <summary>
        /// The transfer id
        /// </summary>
        public Guid TransferId { get; set; }

        /// <summary>
        /// Gets the upload URI for the client encoded in a QR code base64 string
        /// </summary>
        public string QrCode { get; set; }

        /// <summary>
        /// Gets the upload URI for the client
        /// </summary>
        public string UploadUri { get; set; }
    }

}
