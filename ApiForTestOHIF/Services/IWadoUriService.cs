using ApiForTestOHIF.Models;

namespace ApiForTestOHIF.Services
{
    public interface IWadoUriService
    {
        HttpResponseMessage GetInstance(IWadoUriRequest request);
    }
}
