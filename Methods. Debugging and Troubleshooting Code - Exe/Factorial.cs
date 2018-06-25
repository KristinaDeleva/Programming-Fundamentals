using System;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FactorialNumber(n);
        }

        static BigInteger FactorialNumber(int n)
        {
            BigInteger sum = 0;
            if (n == 1)
            {
                return 1;
            }
            else
            {
                sum = FactorialNumber(n - 1) * n;
                return sum;
            }
        }
    }
}
