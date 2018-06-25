using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            nums = nums.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
