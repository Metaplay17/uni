using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ArrayExtension
    {
        public static string ToString<T>(this T[] array)
        {
            return $"{string.Join(" ", array)}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Decline(num);
                FibContains(num);
                PrimesArray(num);
                if (num % 2 == 1)
                {
                    BritainFlag(num);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("INCORRECT INPUT");
            }
            Console.ReadKey();
        }
        static void Decline(int count)
        {
            string name = "яблок";
            if (count % 100 >= 11 && count % 100 <= 14)
            {
                Console.WriteLine($"{count} {name}");
            }
            else if (count % 10 == 1)
            {
                Console.WriteLine($"{count} {name}о");
                return;
            }
            else if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4)
            {
                Console.WriteLine($"{count} {name}а");
                return;
            }
            else
            {
                Console.WriteLine($"{count} {name}");
            }
        }
        static void FibContains(int n)
        {
            if (n < 1)
            {
                throw new Exception();
            }
            else if (n == 1 || n == 2)
            {
                Console.WriteLine(true);
            }
            int a = 1, b = 1, c = a + b;
            while (c < n)
            {
                b = a;
                a = c;
                c = a + b;
                if (c == n)
                {
                    Console.WriteLine(true);
                    return;
                }
            }
            Console.WriteLine(false);
        }
        static void PrimesArray(int n)
        {
            List<int> primes = new List<int> { 2 };
            for (int num = 3; num <= n; num += 2)
            {
                bool isPrime = true;
                foreach (int d in primes)
                {
                    if (num % d == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(num);
                }
            }
            Console.WriteLine(ArrayExtension.ToString(primes.ToArray()));
        }
        static void BritainFlag(int n)
        {
            int delta = (n - 1) / 2;
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1 || i == j || i == delta || j == delta)
                    {
                        arr[i, j] = 1;
                    }
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
