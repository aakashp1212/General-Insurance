using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistration objcustomer;

        public RegistrationController(IRegistration _objcustomer)
        {
            objcustomer = _objcustomer;

        }
        [HttpGet]
        public IActionResult Get()
        {
            var res = objcustomer.GetALLCustomer();
            return Ok(res);
        }

        [HttpPost]
        public int Post( CustomerRegistration customer)
        {
            return objcustomer.AddCustomer(customer);
        }

        [HttpGet("{PolicyNumber}")]
        public CustomerRegistration Get(int PolicyNumber)
        {
            return objcustomer.GetCustomerById(PolicyNumber);  
        }
            
        


    }
}
