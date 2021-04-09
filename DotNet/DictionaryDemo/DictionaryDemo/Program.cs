using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, elain> kirja = new();

            // Lisätään eläimiä listaan
            kirja.Add(1001, new elain("koira"));
            kirja.Add(1002, new elain("kissa"));
            kirja.Add(1003, new elain("lehmä"));

            Console.WriteLine(kirja[1003].Laji);
            // > lehmä
        }
    }

    class elain
    {
        public string Laji { get; set; }
    
        public elain(string nimi)
        {
            Laji = nimi;
        }
    }
}
