using ApiForTestOHIF.Writers;

namespace ApiForTestOHIF.Factories
{
    public interface IDicomMediaWriterFactory
    {
        IDicomMediaWriter GetMediaWriter(string mediaType);
    }
}
