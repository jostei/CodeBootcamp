using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Elain> kirja = new();

            // Lisätään eläimiä listaan
            kirja.Add(1001, new Elain("koira"));
            kirja.Add(1002, new Elain("kissa"));
            kirja.Add(1003, new Elain("lehmä"));

            Console.WriteLine(kirja[1003].Laji);
            // > lehmä

            Dictionary<Uhanalaisuus, List<Elain>> Luontokirja = new();

            Luontokirja.Add(Uhanalaisuus.EiUhanalainen, new List<Elain>());
            Luontokirja.Add(Uhanalaisuus.Vaarassa, new List<Elain>());
            Luontokirja.Add(Uhanalaisuus.Uhanalainen, new List<Elain>());
            Luontokirja.Add(Uhanalaisuus.Fiktiivinen, new List<Elain>());

            Luontokirja[Uhanalaisuus.EiUhanalainen].Add(new Elain("Kissa"));
            Luontokirja[Uhanalaisuus.EiUhanalainen].Add(new Elain("Koira"));
            Luontokirja[Uhanalaisuus.Vaarassa].Add(new Elain("Saimaannorppa"));
            Luontokirja[Uhanalaisuus.Uhanalainen].Add(new Elain("Siperiantiikeri"));
            Luontokirja[Uhanalaisuus.Fiktiivinen].Add(new Elain("Yksisarvinen"));
            Luontokirja[Uhanalaisuus.Fiktiivinen].Add(new Elain("Lohikäärme"));


        }
    }
    public enum Uhanalaisuus
    {
        EiUhanalainen,
        Vaarassa,
        Uhanalainen,
        Fiktiivinen
    }

    class Elain
    {
        public string Laji { get; set; }
    
        public Elain(string nimi)
        {
            Laji = nimi;
        }
    }
}
