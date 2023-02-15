using ApiForTestOHIF.Models;
using FellowOakDicom;

namespace ApiForTestOHIF.Factories
{
    public interface IDicomMediaIdFactory
    {
        IMediaId Create(IObjectId objectId, DicomMediaProperties mediaInfo);

        IMediaId Create
        (
            DicomDataset dataset,
            int frame,
            string mediaType,
            string transferSyntax
        );

        IMediaId Create(string[] parts);
    }
}
