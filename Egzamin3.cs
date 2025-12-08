using System;

namespace WypozyczalniaFilmow
{
    class Film
    {
        // Używamy 'protected', ponieważ treść zadania wymaga, aby dostęp miała 
        // klasa oraz klasy potomne (w przypadku rozszerzenia).
        protected string tytul;
        protected int liczbaWypozyczen;

        // Konstruktor: Inicjalizacja pól wartością pustą lub 0
        public Film()
        {
            tytul = "";
            liczbaWypozyczen = 0;
        }

        // Metoda ustawiająca tytuł (setter)
        public void UstawTytul(string nowyTytul)
        {
            // Dodatkowe sprawdzenie założenia o max 20 znakach (dla kompletności)
            if (nowyTytul.Length > 20)
            {
                // Jeśli tytuł jest za długi, ucinamy go do 20 znaków
                tytul = nowyTytul.Substring(0, 20);
            }
            else
            {
                tytul = nowyTytul;
            }
        }

        // Metoda pobierająca tytuł (getter)
        public string PobierzTytul()
        {
            return tytul;
        }

        // Metoda pobierająca liczbę wypożyczeń (getter)
        public int PobierzLiczbeWypozyczen()
        {
            return liczbaWypozyczen;
        }

        // Metoda inkrementująca liczbę wypożyczeń
        public void Inkrementuj()
        {
            liczbaWypozyczen++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // 1. Inicjalizacja obiektu i wyświetlenie zawartości pól (stan początkowy)
            Film film = new Film();
            Console.WriteLine("1. Stan początkowy obiektu:");
            Console.WriteLine($"   Tytuł: '{film.PobierzTytul()}'");
            Console.WriteLine($"   Liczba wypożyczeń: {film.PobierzLiczbeWypozyczen()}");

            // 2. Test metody set (ustawienie tytułu)
            Console.WriteLine("\n2. Ustawianie tytułu filmu...");
            film.UstawTytul("Matrix"); // Przykładowy tytuł

            // 3. Test metody get (pobranie i wyświetlenie tytułu)
            Console.WriteLine($"   Pobrany tytuł po zmianie: {film.PobierzTytul()}");

            // 4. Test metody inkrementacji (przed i po)
            Console.WriteLine("\n3. Test inkrementacji wypożyczeń:");

            // Wyświetlenie przed inkrementacją
            int przed = film.PobierzLiczbeWypozyczen();
            Console.WriteLine($"   Wartość przed inkrementacją: {przed}");

            // Wykonanie metody inkrementuj
            film.Inkrementuj();

            // Wyświetlenie po inkrementacji
            int po = film.PobierzLiczbeWypozyczen();
            Console.WriteLine($"   Wartość po inkrementacji: {po}");

            // Zatrzymanie konsoli, aby zobaczyć wynik
            Console.ReadKey();
        }
    }
}