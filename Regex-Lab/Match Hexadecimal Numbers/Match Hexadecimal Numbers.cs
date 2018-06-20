using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var reg = Regex.Matches(input, pattern);

            var matched = reg.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", matched));
        }
    }
}
