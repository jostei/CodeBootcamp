using System;
using System.Collections.Generic;

namespace GeneerisetTietotyypit
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyLuokka dl1 = new(11);
            DummyLuokka dl2 = new(52);
            DummyLuokka dl3 = new(96);
            List<DummyLuokka> dummyLista = new();
            List<string> stringLista = new();

            dummyLista.Add(dl1);
            dummyLista.Add(dl2);
            dummyLista.Add(dl3);

            foreach(DummyLuokka dl in dummyLista)
            {
                Console.WriteLine(dl.Luku);
            }

            stringLista.Add("Hei");
            stringLista.Add("Moi");
            stringLista.Add("Moro");

            foreach (string str in stringLista)
            {
                Console.WriteLine(str);
            }
        }
    }

    class DummyLuokka
    {
        public int Luku { get; set; }

        public DummyLuokka(int a)
        {
            Luku = a;
        }
    }
}
