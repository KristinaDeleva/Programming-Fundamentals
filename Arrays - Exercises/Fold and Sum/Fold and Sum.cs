using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            int[] upper = new int[nums.Length / 2];
            int[] lower = new int[nums.Length / 2];

            for (int i = 0; i < 2 * k; i++)
            {
                lower[i] = nums[k + i];
            }

            for (int i = 0; i < k; i++)
            {
                upper[i] = nums[k - 1 - i];
                upper[k + i] = nums[4 * k - 1 - i];
            }

            int[] sum = new int[2 * k];

            for (int i = 0; i < 2*k; i++)
            {
                sum[i] = upper[i] + lower[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
