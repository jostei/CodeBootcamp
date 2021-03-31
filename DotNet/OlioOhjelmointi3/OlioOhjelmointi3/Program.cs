using System;

namespace OlioOhjelmointi3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toiminnassa = true;

            Auto perusauto = new();
            Urheiluauto sporttiauto = new();

            Console.WriteLine("\nAUTOSIMULAATTORI 1991\n");
            Console.WriteLine("Kontrolloi Autoa tai Urheiluautoa numeroilla 1-8 tai valitse 0 lopettaaksesi.");
            Console.WriteLine("[    Auto     ] 1: kaasuta, 2: jarruta, 3: avaa katto, 4: sulje katto");
            Console.WriteLine("[ Urheiluauto ] 5: kaasuta, 6: jarruta, 7: avaa katto, 8: sulje katto");

            int valinta = 0;

            while (toiminnassa)
            {
                try
                {
                    valinta = int.Parse(Console.ReadLine());
                }
                catch(FormatException a)
                {
                    valinta = 9;
                }
                switch (valinta){
                    case 1:
                        perusauto.PainaKaasua();
                        continue;
                    case 2:
                        perusauto.PainaJarrua();
                        continue;
                    case 3:
                        perusauto.AvaaKatto();
                        continue;
                    case 4:
                        perusauto.SuljeKatto();
                        continue;
                    case 5:
                        sporttiauto.PainaKaasua();
                        continue;
                    case 6:
                        sporttiauto.PainaJarrua();
                        continue;
                    case 7:
                        sporttiauto.AvaaKatto();
                        continue;
                    case 8:
                        sporttiauto.SuljeKatto();
                        continue;
                    case 9:
                        Console.WriteLine("Virhe! Käytä vain numeroita 1-8 ja 0.");
                        continue;
                    case 0:
                        toiminnassa = false;
                        break;
                    default:
                        continue;

                }
            }
            Console.WriteLine("Autoilu lopetettu.");
        }
    }
}
