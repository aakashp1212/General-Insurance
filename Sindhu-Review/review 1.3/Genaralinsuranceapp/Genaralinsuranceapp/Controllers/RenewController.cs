using Genaralinsuranceapp.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Genaralinsuranceapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenewController : ControllerBase
    {
        private readonly IRenew objrenew;

        public RenewController(IRenew _objrenew)
        {
            objrenew = _objrenew;

        }
    }
}
