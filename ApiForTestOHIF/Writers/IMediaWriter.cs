using ApiForTestOHIF.Models;
using ApiForTestOHIF.Storage;

namespace ApiForTestOHIF.Writers
{
    public interface IMediaWriter<T>
    {
        IList<IStorageLocation> CreateMedia(T data, ILocationProvider storage);

        IList<IStorageLocation> CreateMedia(T data);

        string MediaType
        {
            get;
        }
    }
}
