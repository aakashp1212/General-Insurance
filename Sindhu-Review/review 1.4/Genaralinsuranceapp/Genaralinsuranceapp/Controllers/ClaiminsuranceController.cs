using Genaralinsuranceapp.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Genaralinsuranceapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaiminsuranceController : ControllerBase
    {
        private readonly IClaiminsurance objclaiminsurance;

        public ClaiminsuranceController(IClaiminsurance _objclaiminsurance)
        {
            objclaiminsurance = _objclaiminsurance;
        }


    }

}
