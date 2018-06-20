using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] counter = new int[num.Length];
            int counterMax = 0;
            int numMax = 0;

            for (int i = 0; i < num.Length; i++)
            {
                for (int k = i; k < num.Length; k++)
                {
                    if (num[i] == num[k])
                    {
                        counter[i]++;
                        if (counter[i] > counterMax)
                        {
                            counterMax = counter[i];
                            numMax = num[i];
                        }
                    }
                }
            }

            Console.WriteLine(numMax);
        }
    }
}
