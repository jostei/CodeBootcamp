using System;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkHarjoitus.Models;
using System.Linq;

namespace EntityFrameworkHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext konteksti = new();

            // LINQ-kysely
            var suomalaiset = konteksti.Customers.Where(c => c.Country == "Finland");

            foreach (var asiakas in suomalaiset)
            {
                Console.WriteLine(asiakas.CompanyName);
            }

            // Lataa turhaan koko tietokannan, käytä vain pienissä tietokannoissa
            /*
            foreach (var asiakas in konteksti.Customers)
            {
                if(asiakas.Country == "Finland")
                {
                    Console.WriteLine(asiakas.CompanyName);
                }
            }
            */
        }
    }
}