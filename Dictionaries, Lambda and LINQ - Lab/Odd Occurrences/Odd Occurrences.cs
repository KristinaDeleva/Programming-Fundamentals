using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');

            var count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }

            var result = count
            .Where(w => w.Value % 2 == 1)
            .ToDictionary(x => x.Key, x => x.Value)
            .Keys
            .ToArray();

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
