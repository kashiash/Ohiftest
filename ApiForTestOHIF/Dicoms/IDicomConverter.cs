using FellowOakDicom;

namespace ApiForTestOHIF.Dicoms
{
    public interface IDicomConverter<T>
    {

        T Convert(DicomDataset dicom);

        DicomDataset Convert(T value);
    }
}
