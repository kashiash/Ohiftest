using ApiForTestOHIF.Dicoms;
using ApiForTestOHIF.Models;
using FellowOakDicom;

namespace ApiForTestOHIF.Services
{
    public interface IDicomQueryService
    {
        IEnumerable<DicomDataset> Find
        (
            DicomDataset request,
            IQueryOptions options,
            string queryLevel
        );

        PagedResult<DicomDataset> FindPaged
        (
            DicomDataset request,
            IQueryOptions options,
            string queryLevel
        );
    }
}
