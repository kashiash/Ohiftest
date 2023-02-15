namespace ApiForTestOHIF.Models
{
    public interface IStorageLocation
    {
        string ContentType { get; }
        string Name { get; }
        string ID { get; }
        IMediaId MediaId { get; }
        string Metadata { get; set; }

        bool Exists();
        long GetSize();
        void Delete();
        Stream Download();
        void Download(Stream stream);
        void Upload(Stream stream, string ContentType = null);
        void Upload(byte[] buffer, string ContentType = null);
        void Upload(string filename, string ContentType = null);

        Stream GetReadStream();
    }
}
