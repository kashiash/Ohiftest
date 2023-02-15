using ApiForTestOHIF.Models;
using ApiForTestOHIF.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiForTestOHIF.Controllers
{
    public class MetadataController : ControllerBase
    {
        protected IWadoRsService WadoService { get; set; }

        public MetadataController
        (
            IWadoRsService wadoService
        )
        {
            WadoService = wadoService;
        }

        [HttpGet]
        [Route("wadors/studies/{StudyInstanceUID}/metadata")]
        [Route("api/studies/{StudyInstanceUID}/metadata")]
        public HttpResponseMessage GetStudiesMetadata
        (
             [FromQuery]
            IWadoRsStudiesRequest request
        )
        {
            return WadoService.RetrieveStudyMetadata(request);
        }

        [HttpGet]
        [Route("wadors/studies/{StudyInstanceUID}/series/{SeriesInstanceUID}/metadata")]
        [Route("api/studies/{StudyInstanceUID}/series/{SeriesInstanceUID}/metadata")]
        public HttpResponseMessage GetSeriesMetadata
        (
            [FromQuery]
            IWadoRsSeriesRequest request
        )
        {
            return WadoService.RetrieveSeriesMetadata(request);
        }

        [HttpGet]
        [Route("wadors/studies/{StudyInstanceUID}/series/{SeriesInstanceUID}/instances/{SOPInstanceUID}/metadata")]
        [Route("api/studies/{StudyInstanceUID}/series/{SeriesInstanceUID}/instances/{SOPInstanceUID}/metadata")]
        public HttpResponseMessage GetInstanceMetadata
        (
            [FromQuery]
            IWadoRsInstanceRequest request
        )
        {
            try
            {
                return WadoService.RetrieveInstanceMetadata(request);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage() { Content = new StringContent(ex.ToJson()) };
            }
        }
    }
}
