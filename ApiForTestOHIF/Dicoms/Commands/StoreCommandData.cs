using FellowOakDicom;

namespace ApiForTestOHIF.Dicoms.Commands
{
    public class StoreCommandData
    {
        public StoreCommandData()
        {
            Metadata = new InstanceMetadata();
        }

        public DicomDataset Dataset { get; set; }
        public InstanceMetadata Metadata { get; set; }
    }
}
