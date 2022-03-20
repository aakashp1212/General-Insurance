using Genaralinsuranceapp.Interfaces;
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
      

    }

   
}
