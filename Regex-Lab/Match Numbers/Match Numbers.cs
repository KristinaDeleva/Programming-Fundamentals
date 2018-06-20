using System;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbers = Regex.Matches(input, pattern);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
