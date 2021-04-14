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
    public class RandomNumberController : ControllerBase
    {
        [HttpGet]
        [Route("rnd")]
        public RandomNumber Get()
        {
            RandomNumber rnd = new RandomNumber
            {
                Satunnainen = new Random().Next(20)
            };

            return rnd;
        }
    }
}
