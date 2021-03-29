using System;

namespace KoodaustaCllaHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä on nimesi?");

            var nimi = Console.ReadLine();

            Console.WriteLine("Hei, "+nimi+"! Annappa jokin luku.");

            var luku1 = Console.ReadLine();
            
            Console.WriteLine("Annoit luvun "+luku1+". Annappa toinenkin.");

            var luku2 = Console.ReadLine();

            var summa = int.Parse(luku1) + int.Parse(luku2);
            
            Console.WriteLine("lukujen summa on: "+summa+". ");
        }
    }
}
