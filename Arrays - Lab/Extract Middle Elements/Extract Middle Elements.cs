using System;
using System.Linq;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();
            string result = GetMiddleElement(nums);
            Console.WriteLine(result);
        }

        static string GetMiddleElement(int[]nums)
        {
            string result = string.Empty;

            if (nums.Length == 1)
            {
                result = "{ " + nums[0] + " }";
                return result;
            }
            else if (nums.Length % 2 == 0)
            {
                result = "{ " + nums[(nums.Length / 2) - 1] + ", " +
                    nums[nums.Length / 2] + " }";
                return result;
            }
            else
            {
                result = "{ " + nums[(nums.Length / 2) - 1] + ", " +
                    nums[nums.Length / 2] + ", " + nums[(nums.Length / 2) + 1]
                    + " }";
                return result;
            }
        }
    }
}
