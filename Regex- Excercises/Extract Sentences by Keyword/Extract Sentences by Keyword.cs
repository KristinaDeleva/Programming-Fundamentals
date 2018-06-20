using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        private static object toarray;

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"\b{word}\b";

            string[] sentences = input.Split(new char[]{'.','!','?'},
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence,pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
