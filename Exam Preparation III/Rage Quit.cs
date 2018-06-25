using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string pattern = @"(\D+)(\d+)";

            var reg = new Regex(pattern);

            var matches = reg.Matches(input);

            StringBuilder result = new StringBuilder();
            List<char> unique = new List<char>();

            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value;
                int repeat = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < repeat; i++)
                {
                    result.Append(text);
                }
                if (repeat != 0)
                {
                    unique.AddRange(text);
                }
            }

            Console.WriteLine($"Unique symbols used: {unique.Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}
