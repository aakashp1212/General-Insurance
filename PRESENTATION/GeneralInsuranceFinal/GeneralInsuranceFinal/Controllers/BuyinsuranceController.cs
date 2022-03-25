using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeneralInsuranceFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyinsuranceController : ControllerBase
    {
        
        
            private readonly IBuyinsurance objbuyinsurance;

            public BuyinsuranceController(IBuyinsurance _objbuyinsurance)
            {
                objbuyinsurance = _objbuyinsurance;
            }

            [HttpPost]
            public IActionResult AddInsurance(Vehiclesdetails vehiclesdetails)
            {
                var result = objbuyinsurance.AddInsurance(vehiclesdetails);
                return this.CreatedAtAction("AddInsurance", $"{result} record added ");
            }

            [HttpGet]
            public IActionResult GetPlans()
            {
                var plan = objbuyinsurance.GetPlans();
                return this.Ok(plan); ;

            }
            [HttpPost]
            [Route("plan")]
            public IActionResult AddPolicy(Policydetails policydetails)
            {
                var result = objbuyinsurance.AddPolicy(policydetails);
                return this.CreatedAtAction("AddPolicy", $"{result} record added ");
            }
        [HttpGet]
        [Route("allPLANS")]
        public IActionResult GetPolicydetails()
        {
            var year = objbuyinsurance.GetPolicydetails();
            return this.Ok(year); ;

        }



        [HttpGet]
            [Route("all")]
            public IActionResult GetDuration()
            {
                var year = objbuyinsurance.GetDuration();
                return this.Ok(year); ;

            }

            [HttpGet("{id}")]
            public IActionResult GetInsuranceById(int id)
            {
                var fetchdata = objbuyinsurance.GetInsuranceById(id);
                return this.Ok(fetchdata);
            }

        [HttpGet]
        [Route("types")]
        public IActionResult GetVehicletypes()
        {
            var type = objbuyinsurance.GetVehicletypes();
            return this.Ok(type); ;

        }




    }
}
