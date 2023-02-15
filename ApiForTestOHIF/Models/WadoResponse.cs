namespace ApiForTestOHIF.Models
{
    public class WadoResponse : IWadoRsResponse
    {
        public WadoResponse() { }
        public WadoResponse(Stream content, string mimeType)
        {
            Content = content;
            ContentLength = Content.Length;
            MimeType = mimeType;
        }

        public Stream Content
        {
            get;
            set;
        }

        public long ContentLength
        {
            get;

            set;
        }

        public MimeMediaType MimeType
        {
            get;
            set;
        }
        public IStorageLocation StorageLocation { get; private set; }
        public string TransferSyntax { get; set; }
    }
}
