using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int counterMax = 0;
            int numMax = 0;

            for (int i = 0; i < num.Length-1; i++)
            {
                if (num[i] == num[i+1])
                {
                    counter++;
                }
                else
                {
                    if (counter>counterMax)
                    {
                        counterMax = counter;
                        numMax = num[i];
                        
                    }
                    counter = 1;
                }

                if (i + 1 == num.Length - 1)
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        numMax = num[i];
                        
                    }
                    counter = 1;
                }
            }

            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numMax + " ");
            }
        }
    }
}
