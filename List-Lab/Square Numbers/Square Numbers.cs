using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> select = numbers.Where(num => Math.Sqrt(num)
            == (int)Math.Sqrt(num)).ToList();
            select = select.OrderByDescending(a => a).ToList();
            Console.WriteLine(string.Join(" ", select));

            //List<int> numbers = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .Where(x => x >= 0)
            //    .ToList();
            //List<int> squareNumbers = new List<int>();
            //foreach (int number in numbers)
            //{
            //    int sqRoot = (int)Math.Sqrt(number);
            //    if (sqRoot * sqRoot == number)
            //        squareNumbers.Add(number);
            //}
            //Console.WriteLine(string.Join(" ", squareNumbers.OrderBy(x => -x)));
        }
    }
}
