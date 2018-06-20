using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToList();

            foreach (var num in numbers.Distinct().OrderBy(a => a))
            {
                Console.WriteLine(string.Join(" -> ", num, numbers.Count(a => a == num)));
            }
        }
    }
}
