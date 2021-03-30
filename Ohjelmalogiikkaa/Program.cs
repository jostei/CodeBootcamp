using System;

namespace Ohjelmalogiikkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tähän ohjelmaan on tallennettu kaksi lukua");

            int luku = 2;
            int toinenluku;

            toinenluku = 7;
            const int pysyvaluku = 3;

            int vipu = 0;

            Console.WriteLine("O_o ?");
            
            if(luku >= toinenluku){
                Console.WriteLine("luku >= toinenluku");
                vipu = 1;
            }
            else{
                Console.WriteLine("luku < toinenluku");    
                vipu = 2;
            }

            Console.WriteLine("Tämä ohjelma myös looppaa lukuja pienemmästä suurempaan yksi kerrallaan.");

            if(vipu == 1){
                for(int i = toinenluku; i <= luku; i++ ){
                    Console.WriteLine(i);
                }
            }
            else{
                for(int i = luku; i <= toinenluku; i++){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
