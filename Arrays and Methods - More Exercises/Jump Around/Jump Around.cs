using System;
using System.Linq;

namespace Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i] + i < numbers.Length)
                {
                    i += numbers[i] - 1;
                }
                else if (numbers[i] + i >= 0)
                {
                    i -= numbers[i] + 1;
                }
                if (i < 0 || i >= numbers.Length)
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
