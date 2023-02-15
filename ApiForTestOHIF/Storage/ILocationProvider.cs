using ApiForTestOHIF.Models;

namespace ApiForTestOHIF.Storage
{
    public interface ILocationProvider
    {
        IStorageLocation GetLocation(IMediaId key);
    }
}
