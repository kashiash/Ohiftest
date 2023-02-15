namespace ApiForTestOHIF.Dicoms.Commands
{
    public interface IDCloudCommand<T, R>
    {
        R Execute(T dataObject);
    }
}
