using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stanowisko
    {
        public string Nazwa { get; private set; }
        public double Wspolczynnik { get; private set; }

        public Stanowisko(string nazwa, double wspolczynnik)
        {
            Nazwa = nazwa;
            Wspolczynnik = wspolczynnik;


        }
    }
}
