using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new("<table>");
            DateTime alku = DateTime.Now;

            /*
            string html = "<table>";
            for(int i = 0; i < 100000; i++)
            {
                html += "<tr><td>" + i + "</td></tr>\r\n";
            }
            html += "</table>";
            */

            for (int i = 0; i < 100000; i++)
            {
                sb.Append("<tr><td>" + i + "</td></tr>\r\n");
            }
            sb.Append("</table>");

            Console.WriteLine("HTML-koodin pituus: " + sb.Length);
            DateTime loppu = DateTime.Now;
            TimeSpan kesto = loppu - alku;
            Console.WriteLine($"HTML-koodin muodostus kesti: {kesto.TotalSeconds}.");
        }
    }
}
