using System.Net.Http.Headers;

namespace ApiForTestOHIF.Models
{
    public interface IWadoRequestHeader
    {
        HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> AcceptHeader { get; set; }
        HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharsetHeader { get; set; }
        HttpRequestHeaders Headers { get; set; }

    }
}
