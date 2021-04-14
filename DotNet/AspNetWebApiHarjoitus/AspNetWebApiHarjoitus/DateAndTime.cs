using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiHarjoitus
{
    public class DateAndTime
    {
        public DateTime Paiva { get; set; }

        public DateAndTime()
        {
            Paiva = DateTime.Now;
        }
    }
}
