using ApiForTestOHIF;
using ApiForTestOHIF.Services;
using FellowOakDicom;

internal class ObjectArchieveQueryService : IObjectArchieveQueryService
// public class ObjectArchieveQueryService : DicomQueryServiceBase, IObjectArchieveQueryService
{
    //public ObjectArchieveQueryService(IObjectArchieveDataAccess dataAccess) : base(dataAccess)
    //{ }

    public IEnumerable<DicomDataset> FindStudies
    (
        DicomDataset request,
        IQueryOptions options
    )
    {
        return Find(request, options, Enum.GetName(typeof(ObjectQueryLevel), ObjectQueryLevel.Study));
    }

    public IEnumerable<DicomDataset> FindObjectInstances
    (
        DicomDataset request,
        IQueryOptions options
    )
    {
        return Find(request, options, Enum.GetName(typeof(ObjectQueryLevel), ObjectQueryLevel.Instance));
    }

    public IEnumerable<DicomDataset> FindSeries
    (
        DicomDataset request,
        IQueryOptions options
    )
    {
        return Find(request, options, Enum.GetName(typeof(ObjectQueryLevel), ObjectQueryLevel.Series));
    }

    protected  IEnumerable<DicomDataset> DoFind
    (
       DicomDataset request,
       IQueryOptions options,
       string queryLevel
      
    )
    {
   

        return GnerateFakeResult(); ;// QueryDataAccess.Search(conditions, options, queryLevel);
    }

    private static List<DicomDataset> GnerateFakeResult()
    {
        var result = new List<DicomDataset>();
        foreach (string file in Directory.GetFiles("d:\\dicom\\SampleImages\\"))
        {

            DicomDataset sourceDS = DicomFile.Open(file).Dataset;
            result.Add(sourceDS);
        }

        return result;
    }

    public PagedResult<DicomDataset> FindStudiesPaged
    (
        DicomDataset request,
        IQueryOptions options
    )
    {
        return FindPaged(request, options, Enum.GetName(typeof(ObjectQueryLevel), ObjectQueryLevel.Study));
    }

    public PagedResult<DicomDataset> FindObjectInstancesPaged
    (
        DicomDataset request,
        IQueryOptions options
    )
    {
        return FindPaged(request, options, Enum.GetName(typeof(ObjectQueryLevel), ObjectQueryLevel.Instance));
    }

    public PagedResult<DicomDataset> FindSeriesPaged
    (
        DicomDataset request,
        IQueryOptions options
    )
    {
        return FindPaged(request, options, Enum.GetName(typeof(ObjectQueryLevel), ObjectQueryLevel.Series));
    }

    protected  PagedResult<DicomDataset> DoFindPaged
    (
       DicomDataset request,
       IQueryOptions options,
       string queryLevel

    )
    {

        return null;// QueryDataAccess.SearchPaged(conditions, options, queryLevel);
    }


    public IEnumerable<DicomDataset> Find
(
    DicomDataset request,
    IQueryOptions options,
    string queryLevel
)
    {


        return DoFind(request, options, queryLevel);
    }

    public PagedResult<DicomDataset> FindPaged
(
    DicomDataset request,
    IQueryOptions options,
    string queryLevel
)
    {


        return DoFindPaged(request, options, queryLevel);
    }
}
