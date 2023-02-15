using ApiForTestOHIF.Dicoms.Commands;

namespace ApiForTestOHIF.Factories
{
    public interface IDCloudCommandFactory
    {
        IDeleteCommand CreateDeleteCommand();
        IStoreCommand CreateStoreCommand();
    }
}
