using ApiForTestOHIF.Models;
using FellowOakDicom;

namespace ApiForTestOHIF.Writers
{
    public class DicomMediaWriterParameters
    {
        public DicomDataset Dataset
        {
            get;
            set;
        }

        public DicomMediaProperties MediaInfo
        {
            get;
            set;
        }
    }
}
