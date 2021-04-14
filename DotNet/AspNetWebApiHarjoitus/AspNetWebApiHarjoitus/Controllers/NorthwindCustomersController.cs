using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetWebApiHarjoitus.Models;
using System.Data.SqlClient;

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

        // Lisää vastaanotetun JSONin tietokantaan
        [HttpPost]
        [Route("uusiAsiakas")]
        public void PostUusiAsiakas([FromBody] Customer asiakas)
        {
            NorthwindContext konteksti = new();
            konteksti.Customers.Add(asiakas);
            konteksti.SaveChanges();
        }

        /* JSON esimerkki testaukseen
        {
        "CustomerId" : "AAAAB",
        "CompanyName" : "JSON Testi Oy",
        "ContactName" : "TEST",
        "ContactTitle" : "TEST",
        "Address" : "TEST",
        "City" : "TEST",
        "Region" : "TEST",
        "PostalCode" : "TEST",
        "Country" : "TEST",
        "Phone" : "TEST",
        "Fax" : "TEST"
        }
        */
    }
}
