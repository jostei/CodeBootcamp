using System;

namespace ArvaaLukuPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvotaan luku väliltä 1-20...");

            Random rnd = new Random();
            int arvattavaLuku = rnd.Next(21);
            int kierrostenMaara = 3;

            Console.WriteLine("Saat kolme arvausta. Arvaa Luku.");

            int kierros = 0;
            int arvaus = 0;
            int[] arvatutLuvut = new int[kierrostenMaara];
            bool lukuArvattu = false;

            while(!lukuArvattu & kierros < kierrostenMaara){
                arvaus = Int32.Parse(Console.ReadLine());
                arvatutLuvut[kierros] = arvaus;
                kierros++;

                if(arvaus > arvattavaLuku & kierros < kierrostenMaara){
                    Console.WriteLine("Liian suuri, yritä uudestaan!");
                }
                if(arvaus < arvattavaLuku & kierros < kierrostenMaara){
                    Console.WriteLine("Liian pieni, yritä uudestaan!");
                }
                if(arvaus == arvattavaLuku){
                    Console.WriteLine("Oikein!!");
                    lukuArvattu = true;
                    break;
                }
            }

            if(!lukuArvattu){
                Console.WriteLine("Et arvannut. Luku oli: "+arvattavaLuku+".");
                Console.Write("Arvaamasi luvut: ");
                foreach (int luku in arvatutLuvut)
                {
                    Console.Write(luku+" ");                    
                }
            }
        }
    }
}
