using ApiForTestOHIF.Models;

namespace ApiForTestOHIF.Dicoms.Commands
{
    public class DeleteCommandData
    {
        public IEnumerable<IObjectId> Instances { get; set; }
        public ObjectQueryLevel DeleteLevel { get; set; }
    }
}
