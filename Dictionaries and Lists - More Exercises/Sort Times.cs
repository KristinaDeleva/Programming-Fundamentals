using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortTime = Console.ReadLine().Split(' ').OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", sortTime));

        }
    }
}
