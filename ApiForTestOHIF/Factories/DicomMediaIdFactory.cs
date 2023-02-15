using ApiForTestOHIF.Models;
using FellowOakDicom;

namespace ApiForTestOHIF.Factories
{
    public class DicomMediaIdFactory : IDicomMediaIdFactory
    {
        public virtual IMediaId Create(IObjectId objectId, DicomMediaProperties mediaInfo)
        {
            return new DicomMediaId(objectId, mediaInfo);
        }

        public IMediaId Create
        (
            DicomDataset dataset,
            int frame,
            string mediaType,
            string transferSyntax
        )
        {
            return new DicomMediaId(dataset, frame, mediaType, transferSyntax);
        }

        public virtual IMediaId Create(string[] parts)
        {
            return new DicomMediaId(parts);
        }
    }
}
