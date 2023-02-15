namespace ApiForTestOHIF
{
    public class ObjectId : IObjectId
    {
        public string SeriesInstanceUID
        {
            get;
            set;
        }

        public string SOPInstanceUID
        {
            get;
            set;
        }

        public string StudyInstanceUID
        {
            get;
            set;
        }

        public int? Frame { get; set; }
    }
}
