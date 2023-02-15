namespace ApiForTestOHIF.Models
{
    public interface IQidoQuery
    {
        List<string> IncludeElements
        {
            get;
        }
        Dictionary<string, string> MatchingElements
        {
            get;
        }

        Dictionary<string, string> CustomParameters { get; }
    }
}
