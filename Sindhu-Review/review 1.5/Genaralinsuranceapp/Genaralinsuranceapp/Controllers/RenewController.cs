using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
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

        [HttpPut]
        public IActionResult Updatepolicy(Policydetails policydetails)
        {
            var result = objrenew.Updatepolicy(policydetails);
            return this.CreatedAtAction("Updatepolicy(", $"{result} record added ");
        }
        [HttpGet]

        public IActionResult GetAllPolicies()
        {
            var fetchData = objrenew.GetAllPolicies();
            return this.Ok(fetchData);
        }
    }
}
