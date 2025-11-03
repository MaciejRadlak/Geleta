using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Firma
    {
        public string Nazwa { get; private set; }
        public string Adres { get; private set; }
        private List<Pracownik> pracownicy = new List<Pracownik>();
        private Random rand = new Random();

        public Firma(string nazwa, string adres)
        {
            Nazwa = nazwa;
            Adres = adres;
        }

        public void DodajPracownika(Pracownik p)
        {
            pracownicy.Add(p);
        }

        public void DodajPracownika(string imieNazwisko, Stanowisko stanowisko)
        {
            var dane = imieNazwisko.Split(' ');
            if (dane.Length >= 2)
            {
                var p = new Pracownik(dane[0], dane[1], stanowisko);
                DodajPracownika(p);
            }
        }

        public void Pracuj()
        {
            foreach (var p in pracownicy)
            {
                p.Pracuj();
                double nowyWspolczynnik = p.Stanowisko.Wspolczynnik * rand.Next(1, 5);
                var noweStanowisko = new Stanowisko(p.Stanowisko.Nazwa, nowyWspolczynnik);
                p.ZmienStanowisko(noweStanowisko);
            }
        }

        public void WypiszPracownikow()
        {
            Console.WriteLine($"Firma: {Nazwa}, Adres: {Adres}");
            foreach (var p in pracownicy)
            {
                Console.WriteLine($"{p.Imie} {p.Nazwisko}, Stanowisko: {p.Stanowisko.Nazwa}, Współczynnik: {p.Stanowisko.Wspolczynnik}, Staż: {p.PokazStaz()}");
            }
        }

        public double SumaWspolczynnikow()
        {
            return pracownicy.Sum(p => p.Stanowisko.Wspolczynnik);
        }

        public static Firma Porownaj(Firma f1, Firma f2)
        {
            return f1.SumaWspolczynnikow() > f2.SumaWspolczynnikow() ? f1 : f2;
        }
    }
}
