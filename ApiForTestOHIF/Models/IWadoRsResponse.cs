namespace ApiForTestOHIF.Models
{
    public interface IWadoRsResponse
    {
        Stream Content { get; set; }
        MimeMediaType MimeType { get; set; }
        string TransferSyntax { get; set; }
        long ContentLength { get; set; }
    }
}
