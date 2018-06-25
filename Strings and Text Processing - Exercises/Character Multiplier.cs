using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            string lineOne = input[0];
            string lineTwo = input[1];

            int min = Math.Min(lineOne.Length, lineTwo.Length);
            int max = Math.Max(lineOne.Length, lineTwo.Length);
            int sum = 0;

            for (int i = 0; i < min; i++)
            {
                sum += lineTwo[i] * lineOne[i];
            }

            for (int i = min; i < max; i++)
            {
                try
                {
                    sum += lineOne[i];
                }
                catch 
                {
                    sum += lineTwo[i];
                    
                }
            }

            Console.WriteLine(sum);
        }
    }
}
