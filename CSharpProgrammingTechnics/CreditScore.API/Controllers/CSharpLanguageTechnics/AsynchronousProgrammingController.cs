using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScore.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreditScore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsynchronousProgrammingController : ControllerBase
    {

        private readonly ICreditScoreBusiness _creditScoreBusiness;

        public AsynchronousProgrammingController(ICreditScoreBusiness creditScoreBusiness)
        {
            _creditScoreBusiness = creditScoreBusiness;
        }
        [HttpGet]
        public async Task<IActionResult> GetCreditScore()
        {
            var a = 0;
            try
            {
               a = await Task.FromResult(_creditScoreBusiness.GetCreditScore());
            }
            catch(Exception ex)
            {
                throw (ex.InnerException);
            }

            return Ok(a);
            
            
        }
    }
}