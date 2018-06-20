using System;

namespace Prime_Checker
{
    class Program
    {
        private static int cnt;

        static void Main(string[] args)
        {
            IsPrime();
        }

        static void IsPrime()
        {
            double n = double.Parse(Console.ReadLine()); ;
            double counter = Math.Sqrt(n);
            bool isPrime = true;
            if (n > 1)
            {
                for (int i = 2; i <= counter; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }
            if (isPrime)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
