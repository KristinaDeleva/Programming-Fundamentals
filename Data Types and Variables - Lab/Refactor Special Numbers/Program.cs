using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int currenty = 0;
            int sum = 0;
            bool special = false;
            for (int i = 1; i <= count; i++)
            {
                sum = i;
                while (i > 0)
                {
                    currenty += i % 10;
                    i = i / 10;
                }
                special = (currenty == 5) || (currenty == 7) || (currenty == 11);
                Console.WriteLine($"{sum} -> {special}");
                currenty = 0;
                i = sum;
            }

        }
    }
}
