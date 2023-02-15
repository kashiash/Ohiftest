using ApiForTestOHIF.Dicoms.Commands;
using ApiForTestOHIF.Models;
using FellowOakDicom;

namespace ApiForTestOHIF.Dicoms.Retrieve
{
    public interface IObjectStoreService
    {
        DCloudCommandResult StoreDicom(DicomDataset dataset, InstanceMetadata metadata);
        DCloudCommandResult Delete(DicomDataset request, ObjectQueryLevel level);
    }
}
