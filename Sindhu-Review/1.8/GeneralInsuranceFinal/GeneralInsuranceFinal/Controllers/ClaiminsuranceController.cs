using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeneralInsuranceFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaiminsuranceController : ControllerBase
    {
        
            private readonly IClaim objclaim;

            public ClaiminsuranceController(IClaim _objclaim)
            {
                objclaim = _objclaim;
            }

            [HttpGet("{email}")]
            public IActionResult GetPolicyByEmail(string email)
            {
                var fetchdata = objclaim.GetPolicyByEmail(email);
                return this.Ok(fetchdata);
            }

            [HttpGet]

            public IActionResult Getclaimreasons()
            {
                var fetchData = objclaim.Getclaimreasons();
                return this.Ok(fetchData);
            }

            [HttpPost]
            public IActionResult AddClaimdetails(Claimhistory claimdata)
            {
                var result = objclaim.AddClaimdetails(claimdata);
                return this.CreatedAtAction("AddClaimdetail", $"{result} record added ");
            }

        }
    }
