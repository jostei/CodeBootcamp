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
        // Haetaan kaikki asiakkaat
        [HttpGet]
        [Route("asiakkaat")]
        public List<Customer> KaikkiAsiakkaat()
        {
            NorthwindContext konteksti = new();
            return konteksti.Customers.ToList();
        }

        // Haetaan yhden maan asiakkaat routen perusteella
        [HttpGet]
        [Route("yksiMaa/{maanNimi}")]
        public List<Customer> YksiMaaAsiakas(string maanNimi)
        {
            NorthwindContext konteksti = new();
            return konteksti.Customers.Where(c => c.Country == maanNimi).ToList();
        }
    }
}
