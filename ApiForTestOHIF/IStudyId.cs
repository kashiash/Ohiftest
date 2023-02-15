namespace ApiForTestOHIF
{
    public interface IStudyId
    {
        string StudyInstanceUID { get; set; }
    }
    public interface ISeriesId : IStudyId
    {
        string SeriesInstanceUID { get; set; }
    }
    public interface IObjectId : ISeriesId
    {
        string SOPInstanceUID { get; set; }

        int? Frame { get; set; }
    }
}
