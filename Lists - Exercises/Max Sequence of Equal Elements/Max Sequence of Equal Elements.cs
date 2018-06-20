using System;
using System.Collections.Generic;
using System.Linq;
namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            int count = 1;
            int counterMax = 0;
            int numberMax = 0;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    count++;

                    if (count > counterMax)
                    {
                        counterMax = count;
                        numberMax = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
                if (count > counterMax)
                {
                    counterMax = count;
                    numberMax = numbers[i];
                }
            }

            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numberMax + " ");
            }
        }
    }
}
