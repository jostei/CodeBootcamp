using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi3
{
    class Auto
    {
        public int Nopeus  { get; set; }
        public int MaxNopeus { get; set; }


        public void PainaKaasua()
        {
            if(Nopeus == MaxNopeus)
            {
                Console.WriteLine($"{this.GetType().Name} ei kulje kovempaa!");
            }
            else
            {
                Nopeus += 20;
                Console.WriteLine($"Kaasutetaan {this.GetType().Name}a, nopeus on nyt {Nopeus}");
            }
        }

        public void PainaJarrua()
        {
            if (Nopeus == 0)
            {
                Console.WriteLine($"{this.GetType().Name} ei liiku.");
            }
            else
            {
                Nopeus -= 20;
                Console.WriteLine($"Jarrutetaan {this.GetType().Name}a, nopeus on nyt {Nopeus}");
            }
        }

        public void AvaaKatto()
        {
            Console.WriteLine($"{this.GetType().Name}ssa ei ole avattavaa kattoa!");
        }

        public void SuljeKatto()
        {
            Console.WriteLine($"{this.GetType().Name}ssa ei ole avattavaa kattoa!");
        }
    }
}
