using System;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = FactorialNumber(n);
            BigInteger zeroe = FactorialZeroes(factorial);
            Console.WriteLine(zeroe);
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

        static BigInteger FactorialZeroes(BigInteger n)
        {
            int zeroe = 0;
            bool hasZeroe = true;

            while (hasZeroe == true)
            {
                BigInteger digit = n % 10;
                n /= 10;
                if (digit == 0)
                {
                    zeroe++;
                }
                else
                {
                    hasZeroe = false;
                }
            }
            return zeroe;
        }
    }
}
