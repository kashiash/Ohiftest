using ApiForTestOHIF.Models;

namespace ApiForTestOHIF.Services
{
    public interface IQidoRsService
    {
        HttpResponseMessage SearchForInstances(IQidoRequestModel request);
        HttpResponseMessage SearchForSeries(IQidoRequestModel request);
        HttpResponseMessage SearchForStudies(IQidoRequestModel request);
    }
}
