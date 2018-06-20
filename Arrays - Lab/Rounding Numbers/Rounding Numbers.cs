using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //int[] arr = new int[nums.Length];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    arr[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine($"{nums[i]} => {arr[i]}");
            //}


            string doubleVariable = Console.ReadLine();
            double[] arr = doubleVariable.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int roundNum = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {roundNum}");
            }

            //double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            //foreach (double num in arr)
            //{
            //    int rounded = (int)Math.Round(num, MidpointRounding.AwayFromZero);
            //    Console.WriteLine("{0} => {1}", num, rounded);
            //}
        }
    }
}
