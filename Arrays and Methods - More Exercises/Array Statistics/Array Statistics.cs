using System;
using System.Linq;

namespace Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();

            num.Min();
            num.Max();
            num.Sum();
            num.Average();

            Console.WriteLine($"Min = {num.Min()}\nMax = {num.Max()}\n" +
                $"Sum = {num.Sum()}\nAverage = {num.Average()}");
        }
    }
}
