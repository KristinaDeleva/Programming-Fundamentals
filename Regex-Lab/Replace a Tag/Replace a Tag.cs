using System;
using System.Text.RegularExpressions;

namespace Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replace);
                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }
        }
    }
}
