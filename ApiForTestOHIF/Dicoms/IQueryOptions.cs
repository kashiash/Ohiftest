namespace ApiForTestOHIF.Dicoms
{
    public interface IQueryOptions
    {
        int? Limit { get; set; }

        int? Offset { get; set; }
    }

    public class QueryOptions : IQueryOptions
    {
        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }
}
