using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var pattern = new Regex(@"[sSTtAaRr]");
            var planetPattern = new Regex(@"\@([a-zA-Z]+)[^@\-!:>]*\:([0-9]+)[^@\-!:>]*\!(A|D)\![^@\-!:>]*\-\>[0-9]+");

            List<StringBuilder> afterDecrypt = new List<StringBuilder>();
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string current = Console.ReadLine();
                int key = pattern.Matches(current).Count;

                StringBuilder newString = new StringBuilder();

                foreach (char symbol in current)
                {
                    char changed = (char)(symbol - key);
                    newString.Append(changed);
                }

                afterDecrypt.Add(newString);
            }

            foreach (var planet in afterDecrypt)
            {
                var matched = planetPattern.Match(planet.ToString());

                string name = matched.Groups[1].Value;
                string type = matched.Groups[3].Value;

                if (type == "A")
                {
                    attacked.Add(name);
                }
                if (type == "D")
                {
                    destroyed.Add(name);
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");

            foreach (var planet in attacked.OrderBy(a=>a))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");

            foreach (var planet in destroyed.OrderBy(a=>a))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
