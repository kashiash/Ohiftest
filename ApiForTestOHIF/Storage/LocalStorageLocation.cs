using ApiForTestOHIF.Models;

namespace ApiForTestOHIF.Storage
{
    public class LocalStorageLocation : IStorageLocation
    {
        private long? _size;

        public bool AutoDeleteWriteStream
        {
            get; set;
        }

        public string ID { get; private set; }

        public virtual string Name
        {
            get;
            private set;
        }

        public IMediaId MediaId { get; }

        public long GetSize()
        {
            if (null != _size)
            {
                return _size.Value;
            }
            else
            {
                var fileInfo = new FileInfo(ID);

                _size = fileInfo.Length;

                return _size.Value;
            }
        }

        public LocalStorageLocation(string fileName, IMediaId id = null)
        {
            ID = fileName;
            MediaId = id;
            Name = Path.GetFileName(fileName);
            __MetadataFileName = Path.Combine(fileName, "meta");
            Refresh();
        }

        public virtual Stream Download()
        {
            Refresh();

            return File.Open(ID, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
        }

        public virtual void Download(Stream stream)
        {
            using (FileStream fs = File.OpenRead(ID))
            {
                fs.CopyTo(stream);
            }

            Refresh();
        }

        public virtual void Upload(Stream data, string contentType = null)
        {
            using (FileStream fs = File.Create(ID))
            {
                data.CopyTo(fs);
            }

            WriteMetadata();
        }

        public virtual void Upload(byte[] buffer, string contentType = null)
        {
            File.WriteAllBytes(ID, buffer);
            WriteMetadata();
        }

        public virtual void Upload(string fileName, string contentType = null)
        {
            File.Copy(fileName, ID, true);
            WriteMetadata();
        }

        public virtual Stream GetWriteStream()
        {
            string path = ID;

            //FileOptions options = autoDeletOnClose ? FileOptions.DeleteOnClose : FileOptions.None ;

            return File.Create(path);//, 1024*1024, options );

        }

        public virtual void Delete()
        {
            File.Delete(ID);
        }

        public Stream GetReadStream()
        {
            return File.OpenRead(ID);
        }

        public string ContentType
        {
            get
            {
                return "";
            }
        }

        public string Metadata
        {
            get;

            set;
        }

        public bool Exists()
        {
            return File.Exists(ID);
        }

        private void WriteMetadata()
        {
            if (!string.IsNullOrEmpty(Metadata))
            {
                File.WriteAllText(Path.Combine(ID, ".meta"), Metadata);
            }
        }


        private void Refresh()
        {
            if (File.Exists(__MetadataFileName))
            {
                Metadata = File.ReadAllText(__MetadataFileName);
            }
        }

        private string __MetadataFileName { get; set; }
    }
}
