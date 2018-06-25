using System;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            GetPrime(num1,num2);
        }

        static void GetPrime(int num1, int num2)
        {
            if (num1 < 2)
            {
                num1 = 2;
            }
            bool firstPrime = true;
            for (int i = num1; i <= num2; i++)
            {
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime == true && firstPrime == true)
                {
                    Console.Write(i);
                    firstPrime = false;
                }
                else if (prime)
                {
                    Console.Write(", ");
                    Console.Write(i);
                }
            }

            Console.WriteLine();
        }
    }
}
