namespace ApiForTestOHIF.Models
{
    public class QidoQuery : IQidoQuery
    {
        public QidoQuery()
        {
            MatchingElements = new Dictionary<string, string>();
            CustomParameters = new Dictionary<string, string>();
            IncludeElements = new List<string>();
        }

        public Dictionary<string, string> MatchingElements { get; private set; }
        public Dictionary<string, string> CustomParameters { get; private set; }

        public List<string> IncludeElements { get; private set; }
    }
}
