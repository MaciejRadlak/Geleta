using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
        {
            static void Main()
            {
                var s1 = new Stanowisko("Programista", 1.5);
                var s2 = new Stanowisko("Tester", 1.2);

                var f1 = new Firma("TechCorp", "ul. Informatyczna 1");
                f1.DodajPracownika("Jan Kowalski", s1);
                f1.DodajPracownika("Anna Nowak", s2);

                f1.Pracuj();
                f1.WypiszPracownikow();

                var f2 = new Firma("CodeWorks", "ul. Algorytmiczna 2");
                f2.DodajPracownika("Piotr Zieliński", s1);
                f2.Pracuj();

                var lepszaFirma = Firma.Porownaj(f1, f2);
                Console.WriteLine($"Firma z większą wartością stanowisk: {lepszaFirma.Nazwa}");
            }
        }
}
