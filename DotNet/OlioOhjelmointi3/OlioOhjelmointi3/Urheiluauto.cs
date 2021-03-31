using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi3
{
    class Urheiluauto : Auto
    {
        private bool kattoAuki = false;

        public void AvaaKatto()
        {
            if (!kattoAuki)
            {
                kattoAuki = true;
                Console.WriteLine($"{this.GetType().Name}n katto avattu.");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name}n katto on jo auki!");
            }
        }

        public void SuljeKatto()
        {
            if (kattoAuki)
            {
                kattoAuki = false;
                Console.WriteLine($"{this.GetType().Name} katto suljettu.");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name}n katto on jo kiinni!");
            }
        }
    }
}
