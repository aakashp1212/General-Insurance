using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeneralInsuranceFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RenewinsuranceController : ControllerBase
    {

        private readonly IRenew objrenew;

        public RenewinsuranceController(IRenew _objrenew)
        {
            objrenew = _objrenew;

        }

        [HttpPut]
        public IActionResult Updatepolicy(Policydetails policydetails)
        {
            var result = objrenew.Updatepolicy(policydetails);
            return this.CreatedAtAction("Updatepolicy(", $"{result} record updated ");
        }

        //[HttpPut]
        //[Route("update")]
        //public IActionResult Updatepolicy(int id, Policydetails policydetails)
        //{
        //    var result = objrenew.Updatepolicy(id policydetails);
        //    return this.CreatedAtAction("Updatepolicy(", $"{result} record added ");
        //}


        //[httpget]

        //public iactionresult getallpolicies()
        //{
        //    var fetchdata = objrenew.getallpolicies();
        //    return this.ok(fetchdata);
        //}

    }
}