using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
            var reg = Regex.Matches(input, pattern);

            var matched = reg.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}
