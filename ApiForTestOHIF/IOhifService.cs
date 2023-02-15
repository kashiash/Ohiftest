namespace ApiForTestOHIF
{
    public interface IOhifService
    {
        HttpResponseMessage GetStudies(IStudyId studyId);

        HttpResponseMessage GetSeries(IStudyId studyId, ISeriesId seriesId);

        HttpResponseMessage GetInstances(IStudyId studyUid, ISeriesId seriesUid, IObjectId sopUid);

    }
}
