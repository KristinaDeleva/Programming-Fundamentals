using System;
using System.Text.RegularExpressions;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([A-Za-z]+)(.*)(\1)";

            string[] placeholders = Console.ReadLine().Split("{}".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            var matches = Regex.Matches(text, pattern);
            int count = 0;

            foreach (Match match in matches)
            {
                string decoded = match.Groups[1] + placeholders[count++]
                    + match.Groups[3];
                text = text.Replace(match.Value, decoded);
            }
            Console.WriteLine(text);
        }
    }
}
