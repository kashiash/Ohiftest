namespace ApiForTestOHIF.Models
{
    public class ObjectRetrieveResult
    {
        public ObjectRetrieveResult(IStorageLocation location, string transfer)
        {
            Location = location;
            TransferSyntax = transfer;
        }

        public IStorageLocation Location { get; set; }
        public string TransferSyntax { get; set; }
    }
}
