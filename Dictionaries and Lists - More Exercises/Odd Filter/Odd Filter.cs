using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToList();
            var numListAverage = numList.Average();
            numList = numList.Select(x => x = x > numListAverage ? ++x : --x)
                .ToList();
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
