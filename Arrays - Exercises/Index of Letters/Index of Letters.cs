using System;
using System.Linq;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {word[i]-'a'}");
            }
        }
    }
}
