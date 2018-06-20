using System;
using System.Linq;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int counterMax = 0;
            int position = 0;

            for (int i = 0; i < num.Length-1; i++)
            {
                if (num[i] < num[i + 1])
                {
                    counter++;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = i + 1;
                    }
                }

                else
                {
                    counter = 1;
                }
            }

            int[] result = new int[counterMax];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = num[position - counterMax + 1];
                position++;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
