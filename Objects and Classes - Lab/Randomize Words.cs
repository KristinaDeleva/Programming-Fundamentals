using System;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int pos = rnd.Next(0,words.Length);
                int pos2 = rnd.Next(0,words.Length);

                string temp = words[pos];
                words[pos] = words[pos2];
                words[pos2] = temp;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
