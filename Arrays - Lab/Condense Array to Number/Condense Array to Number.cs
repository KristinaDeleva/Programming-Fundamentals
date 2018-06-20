using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
            }

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

        }
    }
}
