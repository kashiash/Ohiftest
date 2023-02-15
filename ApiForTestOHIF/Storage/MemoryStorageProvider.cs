using ApiForTestOHIF.Models;

namespace ApiForTestOHIF.Storage
{
    public class MemoryStorageProvider : ILocationProvider
    {
        public MemoryStorageProvider()
        {
        }

        public IStorageLocation GetLocation(IMediaId key)
        {
            return new MemoryStorageLocation(Path.Combine(key.GetIdParts()), key);
        }
    }
}
