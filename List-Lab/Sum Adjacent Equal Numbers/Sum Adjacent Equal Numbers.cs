using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            int count = 0;

            while (count < numbers.Count - 1)
            {
                if (numbers[count] == numbers[count+1])
                {
                    numbers[count] += numbers[count + 1];
                    numbers.RemoveAt(count + 1);
                    count--;

                    if (count < 0)
                    {
                        count = 0;
                    }
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
