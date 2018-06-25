using System;
using System.Linq;

namespace Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] number = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            long sum = 0l;
            bool isNoNum = true;

            for (long i = number.Length - 1; i >= 0; i--)
            {
                count++;
                if (number[i] == n)
                {
                    isNoNum = false;
                    break;
                }
            }

            if (isNoNum)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                for (int i = 0; i < number.Length - count; i++)
                {
                    sum += number[i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
