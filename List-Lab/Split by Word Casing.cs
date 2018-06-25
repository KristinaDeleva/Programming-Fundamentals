using System;
using System.Collections.Generic;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(",;:.!()\"'\\/[] ".ToCharArray(), StringSplitOptions.
                RemoveEmptyEntries);
            List<string> upper = new List<string>();
            List<string> lower = new List<string>();
            List<string> mixed = new List<string>();

            foreach (var word in words)
            {
                if (IsUpperWord(word))
                {
                    upper.Add(word);
                }
                else if (IsLowerWord(word))
                {
                    lower.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");
        }

        static bool IsUpperWord(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'A' || symbol > 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLowerWord(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || symbol > 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
