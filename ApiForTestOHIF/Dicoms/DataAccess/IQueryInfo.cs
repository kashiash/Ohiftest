namespace ApiForTestOHIF.Dicoms.DataAccess
{
    public interface IQueryInfo
    {
        bool IsCaseSensitive { get; }
        bool ExactMatch { get; }
        bool SupportFuzzy { get; }
    }
}
