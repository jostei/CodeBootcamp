using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi3
{
    class Auto
    {
        private int nopeus = 0;
        public int maxNopeus = 180;

        public void PainaKaasua()
        {
            if(nopeus == maxNopeus)
            {
                Console.WriteLine($"{this.GetType().Name} ei kulje kovempaa!");
            }
            else
            {
                nopeus += 20;
                Console.WriteLine($"Kaasutetaan {this.GetType().Name}a, nopeus on nyt {nopeus}");
            }
        }

        public void PainaJarrua()
        {
            if (nopeus == 0)
            {
                Console.WriteLine($"{this.GetType().Name} ei liiku.");
            }
            else
            {
                nopeus -= 20;
                Console.WriteLine($"Jarrutetaan {this.GetType().Name}a, nopeus on nyt {nopeus}");
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
