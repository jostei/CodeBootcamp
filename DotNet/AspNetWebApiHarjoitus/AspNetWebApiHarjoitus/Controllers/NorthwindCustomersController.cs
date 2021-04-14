using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetWebApiHarjoitus.Models;

namespace AspNetWebApiHarjoitus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindCustomersController : ControllerBase
    {
        [HttpGet]
        [Route("asiakkaat")]
        public List<Customer> KaikkiAsiakkaat()
        {
            NorthwindContext konteksti = new();
            return konteksti.Customers.ToList();
        }

        [HttpGet]
        [Route("suomiasiakkaat")]
        public List<Customer> Suomiasaikkaat()
        {
            NorthwindContext konteksti = new();
            return konteksti.Customers.Where(c => c.Country == "Finland").ToList();
        }
    }
}
