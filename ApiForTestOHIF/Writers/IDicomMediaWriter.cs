using ApiForTestOHIF.Models;
using ApiForTestOHIF.Storage;

namespace ApiForTestOHIF.Writers
{
    public interface IDicomMediaWriter : IMediaWriter<DicomMediaWriterParameters>
    {
        IList<IStorageLocation> CreateMedia(DicomMediaWriterParameters data, ILocationProvider storage, int[] frameList);
    }
}
