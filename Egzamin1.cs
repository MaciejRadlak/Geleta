using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Osoba
    {
        // 1. Pola prywatne (dostęp tylko w tej klasie)
        private int id;
        private string imie;

        // 2. Ogólnie dostępne pole statyczne zliczające instancje
        public static int LiczbaInstancji = 0;
        
        //3. konstruktor bezparametrowy
        public Osoba()
        {
            this.id = 0;
            this.imie = "";
            LiczbaInstancji++;
        }

        //4.konstruktor z parametrami
        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            LiczbaInstancji++;
        }

        //5.konstruktor kopiujacy
        public Osoba(Osoba innaOsoba)
        {
            this.id=innaOsoba.id;
            this.imie=innaOsoba.imie;
            LiczbaInstancji++;
        }

        //6.metoda wypisujaca imie-przywitanie
        public void Przywitaj(string imieGosc)
        {
            if (string.IsNullOrEmpty(this.imie))
            {
                Console.WriteLine("Brak danych");
            }
            else
            {
                Console.WriteLine($"Cześć {imieGosc},mam na imie {this.imie}");

            }
        }

    }
    //Program głowny
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Liczba instacji na początku: {Osoba.LiczbaInstancji}");


            //Testowanie konstruktorów

            //a) bez parametrow
            Osoba osoba1 = new Osoba();
            Console.WriteLine("Osoba 1:");
            osoba1.Przywitaj("Maciek");

            //b) z parametrami
            Osoba osoba2=new Osoba(1,"Maniek");
            Console.WriteLine("Osoba 2:");
            osoba2.Przywitaj("Maciek");

            //c) kopiujacego
            Osoba osoba3 = new Osoba(osoba2);
            Console.WriteLine("Osoba 3:");
            osoba3.Przywitaj("Maciek");

            //Zmiania licznika instancji
            Console.WriteLine($"Liczba instancji na końcu: {Osoba.LiczbaInstancji}");


        }
    }
}
