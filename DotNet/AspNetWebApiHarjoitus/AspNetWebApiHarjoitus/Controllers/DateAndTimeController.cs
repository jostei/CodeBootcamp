using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiHarjoitus.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class DateAndTimeController : ControllerBase
    {
        [HttpGet]
        [Route("date")]
        public DateAndTime Get()
        {
            DateAndTime deitti = new();

            return deitti;
        }
    }
}