using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistration objcustomer;

        public RegistrationController(IRegistration _objcustomer)
        {
            objcustomer = _objcustomer;

        }
        [HttpGet]
        public IEnumerable<CustomerRegistration> Get()
        {
            return objcustomer.GetALLCustomer();
        }

        [HttpPost]
        public int Post([FromBody] CustomerRegistration customer)
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
