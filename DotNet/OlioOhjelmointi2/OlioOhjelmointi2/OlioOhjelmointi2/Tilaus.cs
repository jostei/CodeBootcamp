using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi2
{
    class Tilaus
    {
        private String tuotenimi;

        public Tilaus()
        {
            tuotenimi = "Ei tuotetta.";
        }
        public Tilaus(String tuote)
        {
            tuotenimi = tuote;
        }

        public String getTuotenimi()
        {
            return tuotenimi;
        }
    }
}
