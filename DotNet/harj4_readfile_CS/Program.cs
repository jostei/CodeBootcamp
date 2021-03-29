using System;
using System.IO;

namespace harj4_readfile_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string data = File.ReadAllText(@"C:\Users\joset\Desktop\Code_bootcamp\NodeJS\harj4_readfile_CS\numeroDir\numerot.txt");

            String[] datalista = data.Split("\r\n");

            int summa = 0;
            foreach(string numero in datalista){
                summa += int.Parse(numero);
            }

            Console.Write(summa);
        }
    }
}