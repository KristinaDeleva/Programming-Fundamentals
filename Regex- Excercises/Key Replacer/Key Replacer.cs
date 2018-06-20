using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z]+)([<|\\])(.*)([<|\\])([A-Za-z]+)";
            var matched = Regex.Match(input, pattern);

            string start = matched.Groups[1].Value;
            string end = matched.Groups[5].Value;

            string input2 = Console.ReadLine();
            string pattern2 = @"start(.*?)end";

            StringBuilder builders = new StringBuilder();
            var result = Regex.Matches(input2, pattern2);

            foreach (Match m in result)
            {
                builders.Append(m.Groups[1].Value);

            }
            if (builders.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(builders);
            }

            //var key = Console.ReadLine();
            //var text = Console.ReadLine();

            //var keysPattern = @"^(?<startKey>[a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]*)$";

            //var keyMatch = Regex.Match(key, keysPattern);

            //if (keyMatch.Success)
            //{
            //    var startKey = keyMatch.Groups["startKey"].Value;
            //    var endKey = keyMatch.Groups["endKey"].Value;

            //    var textPattern = $@"{startKey}(?<word>.*?){endKey}";
            //    var matches = Regex.Matches(text, textPattern);

            //    var result = new StringBuilder();

            //    foreach (Match match in matches)
            //    {
            //        result.Append(match.Groups["word"].Value);
            //    }

            //    Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
    }
}
