using System;
using System.Linq;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool[] primes = new bool[num + 1];
            primes[0] = primes[1] = false;

            for (int i = 2; i <= num; i++)
            {
                primes[i] = true;
            }

            for (int i = 0; i <= num; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                    int p = i;
                    int multiplicate = 1;
                    while (p <= num)
                    {
                        primes[p] = false;
                        multiplicate++;
                        p = i * multiplicate;
                    }
                }
            }
        }
    }
}
