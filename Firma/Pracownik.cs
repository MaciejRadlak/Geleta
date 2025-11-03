using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pracownik
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public Stanowisko Stanowisko { get; private set; }

        public int Wynagrodzenie {  get; private set; }

        private int stazPracy = 0;

        public void SetStaz(int wartosc)
        {
            stazPracy = wartosc;
        }

        private int GetStaz()
        {
            return stazPracy;
        }

        public Pracownik(string imie, string nazwisko, Stanowisko stanowisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Stanowisko = stanowisko;
            stazPracy = 0;
        }

        public void Pracuj()
        {
            
            stazPracy++;
        }

        public void ZmienStanowisko(Stanowisko nowe)
        {
            Stanowisko = nowe;
        }

        public void DajPodwyzke(int size)
        {
            Wynagrodzenie += size;
        }

        public int PokazStaz() => GetStaz();
    }
}
