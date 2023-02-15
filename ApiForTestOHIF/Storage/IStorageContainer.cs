using ApiForTestOHIF.Models;

namespace ApiForTestOHIF.Storage
{
    public interface IStorageContainer
    {
        string Connection
        {
            get;
        }

        IStorageLocation GetLocation(string name = null, IMediaId id = null);
        IEnumerable<IStorageLocation> GetLocations(string key);
        bool LocationExists(string key);
        void Delete();
    }
}
