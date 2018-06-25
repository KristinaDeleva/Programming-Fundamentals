using System;
using System.Collections.Generic;
using System.Linq;


namespace Be_Positive
{
    class Program
    {

        static void Main(string[] args)
        {

            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                List<int> numbersToPrint = new List<int>();

                int[] numbers = Console.ReadLine()
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        numbersToPrint.Add(currentNum);
                    }
                    else
                    {
                        if (j == numbers.Length - 1)
                        {
                            break;
                        }
                        currentNum += numbers[j + 1];
                        if (currentNum >= 0)
                        {
                            numbersToPrint.Add(currentNum);
                        }
                        j++;
                    }
                }

                if (numbersToPrint.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", numbersToPrint));
                }
                else
                {
                    Console.WriteLine("(empty)");

                }
            }
        }
    }
}
    


