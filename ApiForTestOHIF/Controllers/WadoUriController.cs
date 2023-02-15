using ApiForTestOHIF.Models;
using ApiForTestOHIF.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiForTestOHIF.Controllers
{
    public class WadoUriController : ControllerBase
    {
        IWadoUriService ServiceHandler { get; set; }

        public WadoUriController(IWadoUriService serviceHandler)
        {
            ServiceHandler = serviceHandler;
        }

        [Route("wadouri")]
        [Route("api/wadouri")]
        public HttpResponseMessage Get
        (
            [FromQuery] WadoUriRequest request
        )
        {
            if (null == request) { return new HttpResponseMessage(HttpStatusCode.BadRequest); }

            return ServiceHandler.GetInstance(request);
        }
    }
}
