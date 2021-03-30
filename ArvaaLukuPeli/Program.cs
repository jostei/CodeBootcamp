// Arvaa luku-peli, toteutus: jostei
using System;

namespace ArvaaLukuPeli
{
    class Program
    {
        const int maksimiLuku = 20;
        const int kierrostenMaara = 3;

        static void Main(string[] args)
        {
            Console.WriteLine($"Arvotaan luku väliltä 1-{maksimiLuku}...");

            // Arvotaan satunnaisluku väliltä [1,maksimiLuku+1]
            Random rnd = new Random();
            int arvattavaLuku = rnd.Next(1,maksimiLuku+1);

            Console.WriteLine($"Saat {kierrostenMaara} arvausta. Arvaa Luku.");

            int kierros = 0;
            int arvaus;
            int[] arvatutLuvut = new int[kierrostenMaara];
            bool lukuArvattu = false;

            // kysytään käyttäjältä lukua kierrostenMaara kertoja
            while(!lukuArvattu & kierros < kierrostenMaara){
                arvaus = Int32.Parse(Console.ReadLine());
                arvatutLuvut[kierros] = arvaus;
                kierros++;

                // Arvattu luku on liian pieni
                if(arvaus > arvattavaLuku & kierros < kierrostenMaara){
                    Console.WriteLine("Liian suuri, yritä uudestaan!");
                }
                // Arvattu luku on liian suuri
                if(arvaus < arvattavaLuku & kierros < kierrostenMaara){
                    Console.WriteLine("Liian pieni, yritä uudestaan!");
                }
                // Arvaus oikein, lopetetaan lukujen kysely
                if(arvaus == arvattavaLuku){
                    Console.WriteLine("Oikein!!");
                    lukuArvattu = true;
                    break;
                }
            }

            // Jose luku arvattu, paljastetaan oikea luku ja esitellään pelaajan arvaukset
            if(!lukuArvattu){
                Console.WriteLine($"Et arvannut. Luku oli: {arvattavaLuku}.");
                Console.Write("Arvaamasi luvut: ");
                foreach (int luku in arvatutLuvut)
                {
                    Console.Write(luku+" ");                    
                }
            }
            Console.WriteLine("\nPeli on päättynyt.");
        }
    }
}
