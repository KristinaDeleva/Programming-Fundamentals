using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var pattern = @"(^|(?<=\s))([a-z0-9]+)([_.-]?[a-z0-9])*
             @([a-z0-9])+([-.][a-z0-9]+)*\.([a-z0-9]+)([-.][a-z0-9]+)*";

            var matched = Regex.Matches(input, pattern);

            foreach (Match match in matched)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

