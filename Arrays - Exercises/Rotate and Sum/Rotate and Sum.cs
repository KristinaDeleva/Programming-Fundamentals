using System;
using System.Linq;
namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numOfRotation = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];

            for (int i = 0; i < numOfRotation; i++)
            {
                nums = Rotate(nums);
                for (int k = 0; k < nums.Length; k++)
                {
                    sum[k] += nums[k];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        static int[] Rotate(int[] nums)
        {
            int[] rotated = new int[nums.Length];
            int lastNum = nums[nums.Length - 1];

            for (int i = 1; i < rotated.Length; i++)
            {
                rotated[i] = nums[i - 1];
            }

            rotated[0] = lastNum;
            return rotated;
        }
    }
}
