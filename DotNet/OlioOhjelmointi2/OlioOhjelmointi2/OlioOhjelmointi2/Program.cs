using System;

namespace OlioOhjelmointi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Asiakas a = new Asiakas("Pentti", 10);
            Tilaus t = new Tilaus("Sohva");

            Console.WriteLine("Asiakas " + a.getNimi() + " tilaa tuotteen " + t.getTuotenimi());
        }
    }
}
