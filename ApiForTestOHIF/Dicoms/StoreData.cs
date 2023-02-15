namespace ApiForTestOHIF.Dicoms
{
    public class InstanceMetadata
    {
        public InstanceMetadata()
        {

        }

        public string Owner
        {
            get;
            set;
        }

        public DicomMediaLocations[] MediaLocations
        {
            get;
            set;
        }

        public Dictionary<string, string> Properties
        {
            get; set;
        }
    }

    public class DicomMediaLocations
    {
        public string MediaType
        {
            get; set;
        }

        public string TransferSyntax
        {
            get; set;
        }

        public List<MediaLocationParts> Locations
        {
            get; set;
        }
    }

    public class MediaLocationParts
    {
        public string[] Parts
        {
            get; set;
        }
    }
}
