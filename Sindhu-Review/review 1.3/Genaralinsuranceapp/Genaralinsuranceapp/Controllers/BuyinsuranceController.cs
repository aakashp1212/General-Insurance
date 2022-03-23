 using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Genaralinsuranceapp.Controllers
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
        [Route("addvehicledetails")]
        public IActionResult AddInsurance(Vehiclesdetails vehiclesdetails)
        {
            var result = objbuyinsurance.AddInsurance(vehiclesdetails);
            return this.CreatedAtAction("AddInsurance", $"{result} record added ");
        }

        [HttpGet]
        [Route("allvehicledetails")]
        public IActionResult GetAllVehicles()
        {
            var res = objbuyinsurance.GetAllVehicles();
            return this.Ok(res);
        }
        [HttpGet]
        [Route("getplans")]
        public IActionResult GetPlans()
        { 
            var plan = objbuyinsurance.GetPlans();
            return this.Ok(plan); ;
        
        }
       
        [HttpGet]
        [Route("getduration")]
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


    }

   
}
