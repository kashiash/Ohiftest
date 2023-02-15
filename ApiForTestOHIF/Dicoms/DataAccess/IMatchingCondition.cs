using FellowOakDicom;

namespace ApiForTestOHIF.Dicoms.DataAccess
{
    public interface IMatchingCondition : IQueryInfo, IDicomDataParameter
    {
        bool CanMatch(DicomItem element);
    }
}
