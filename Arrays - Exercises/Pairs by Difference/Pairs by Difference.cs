using System;
using System.Linq;
namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int different = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i; k < arr.Length-1; k++)
                {
                    if (Math.Abs(arr[i] - arr[k+1]) == different)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
