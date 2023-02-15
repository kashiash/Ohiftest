namespace ApiForTestOHIF.Models
{
    public interface IWadoRsRequestBase : IWadoRequestHeader
    {
        ObjectQueryLevel QueryLevel { get; set; }
    }

    public interface IWadoRsStudiesRequest : IWadoRsRequestBase, IStudyId
    {
    }

    public interface IWadoRsSeriesRequest : IWadoRsStudiesRequest, ISeriesId
    {

    }

    public interface IWadoRsInstanceRequest : IWadoRsSeriesRequest, IObjectId
    {

    }

    public interface IWadoRsFramesRequest : IWadoRsInstanceRequest
    {
        int[] Frames { get; set; }
    }
}
