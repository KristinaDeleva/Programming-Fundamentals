using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<years>\d{4})\b";
            var dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"];
                var month = date.Groups["month"];
                var years = date.Groups["years"];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {years}");
            }
        }
    }
}
