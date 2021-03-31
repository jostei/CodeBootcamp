using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointi2
{
    class Asiakas
    {
        private String nimi;
        private int rahaaTaskussa;

        public Asiakas(String name, int money)
        {
            nimi = name;
            rahaaTaskussa = money;
        }
        public String getNimi()
        {
            return nimi;
        }
    }
}
