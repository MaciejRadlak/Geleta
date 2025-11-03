using System;
using System.Linq;

namespace Praca_domowa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = GenerateArray(5);

            // 1
            Console.WriteLine("1) Indeks najmniejszego elementu (licząc od 1):");
            Console.WriteLine($"   Tablica: {string.Join(", ", numbers)}");
            Console.WriteLine($"   Wynik: {FindMinIndex(numbers)}\n");

            // 2
            Console.WriteLine("2) Sortowanie tablicy:");
            Console.WriteLine($"   Wejście: {string.Join(", ", numbers)}");
            Console.WriteLine($"   Wynik: {string.Join(", ", SortArray(numbers))}\n");

            // 3
            Console.WriteLine("3) Długość przeciwprostokątnej (twierdzenie Pitagorasa):");
            Console.WriteLine($"   Dane: {numbers[0]}, {numbers[1]}");
            Console.WriteLine($"   Wynik: {Hypotenuse(numbers[0], numbers[1])}\n");

            // 4
            int[] sample = GenerateArray(3);
            Console.WriteLine("4) Odchylenie standardowe:");
            Console.WriteLine($"   Dane: {string.Join(", ", sample)}");
            Console.WriteLine($"   Wynik: {StandardDeviation(sample)}\n");

            // 5
            Console.WriteLine("5) Odwrócenie tablicy:");
            Console.WriteLine($"   Wejście: {string.Join(", ", numbers)}");
            Console.WriteLine($"   Wynik: {string.Join(", ", ReverseArray(numbers))}\n");

            // 6
            Random rng = new Random();
            int randomNumber = rng.Next(5, 40);
            Console.WriteLine("6) Czy liczba jest pierwsza?");
            Console.WriteLine($"   Liczba: {randomNumber}");
            Console.WriteLine($"   Wynik: {(IsPrime(randomNumber) ? "TAK" : "NIE")}\n");

            // 7
            int n = sample[0];
            Console.WriteLine("7) Suma według wzoru i*(i+1)^2:");
            Console.WriteLine($"   n = {n}");
            Console.WriteLine($"   Wynik: {CalculateSum(n)}");
        }

       
        static int[] GenerateArray(int size)
        {
            Random r = new Random();
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
                result[i] = r.Next(1, 6);
            return result;
        }

        
        static int FindMinIndex(int[] arr)
        {
            int index = 0;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < arr[index])
                    index = i;
            return index + 1;
        }

       
        static int[] SortArray(int[] arr)
        {
            int[] copy = (int[])arr.Clone();
            Array.Sort(copy);
            return copy;
        }

        
        static double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

       
        static double StandardDeviation(int[] arr)
        {
            double mean = arr.Average();
            double sum = arr.Sum(x => (x - mean) * (x - mean));
            return Math.Sqrt(sum / arr.Length);
        }

        
        static int[] ReverseArray(int[] arr)
        {
            int[] copy = (int[])arr.Clone();
            Array.Reverse(copy);
            return copy;
        }

       
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
                sum += i * (i + 1) * (i + 1);
            return sum;
        }
    }
}