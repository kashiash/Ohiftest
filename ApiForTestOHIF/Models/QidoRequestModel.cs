using System.Net.Http.Headers;

namespace ApiForTestOHIF.Models
{
    public class QidoRequestModel : IQidoRequestModel
    {
        public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharsetHeader
        {
            get;
            set;
        }

        public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> AcceptHeader
        {
            get;
            set;
        }

        public HttpRequestHeaders Headers { get; set; }

        public bool? FuzzyMatching
        {
            get; set;
        }

        public int? Limit
        {
            get; set;
        }

        public int? Offset
        {
            get; set;
        }

        public QidoQuery Query
        {
            get; set;
        }
    }
}
