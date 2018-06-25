using System;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int toChek = 2; toChek <= num; toChek++)
            {
                bool isPrime = true;
                for (int current = 2; current <= Math.Sqrt(toChek); current++)
                {
                    if (toChek % current == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{toChek} -> {isPrime}");
            }

        }
    }
}
