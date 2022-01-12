using CreditLineRequest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;

using CreditLineRequest.Utils;

namespace CreditLineRequest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditLineController : ControllerBase
    {
        [HttpPost]
        public IActionResult getCredito(CreditLine credit)
        {
            if (credit.foundingType == "SME")
            {
                if (CreditLineUtils.creditRequestSME(credit.monthlyRevenue, credit.requestedCreditLine))
                    return Ok("The credit line has been ACCEPTED.");
                else
                    return Ok("The credit line has been DECLINED.");
            }
            else if (credit.foundingType == "Startup")
            {
                if (CreditLineUtils.creditRequestStartup(credit.monthlyRevenue, credit.cashBalance, credit.requestedCreditLine))
                    return Ok("The credit line has been ACCEPTED.");
                else
                    return Ok("The credit line has been DECLINED.");
            }
            else
                return BadRequest("The founding type is incorrect.");
        }
    }
}
