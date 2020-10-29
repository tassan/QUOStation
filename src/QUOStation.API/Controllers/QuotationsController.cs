using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QUOStation.Domain.Interfaces.Services;

namespace QUOStation.API.Controllers
{
    [Route("quotations/")]
    [ApiController]
    public class QuotationsController : ControllerBase
    {
        private readonly IAwesomeQuotation _awesomeQuotation;

        public QuotationsController(IAwesomeQuotation awesomeQuotation)
        {
            _awesomeQuotation = awesomeQuotation;
        }

        [HttpGet("{currencies}")]
        public IActionResult GetQuotation(string currencies)
        {
            return Ok(_awesomeQuotation.GetQuotation(currencies));
        }
    }
}
