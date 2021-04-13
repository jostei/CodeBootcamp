using System;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkHarjoitus.Models;

namespace EntityFrameworkHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext konteksti = new();
            foreach (var asiakas in konteksti.Customers)
            {
                if(asiakas.Country == "Finland")
                {
                    Console.WriteLine(asiakas.CompanyName);
                }
            }
        }
    }
}