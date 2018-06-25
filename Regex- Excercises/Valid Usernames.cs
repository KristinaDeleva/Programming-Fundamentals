using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string pattern = @"(^[A-Za-z][\w]{2,24})";
            List<string> result = new List<string>();

            foreach (var member in input)
            {
                if (Regex.IsMatch(member,pattern) && member.Length>=3 && member.Length<=25)
                {
                    result.Add(member);
                }
            }

            int counter = 0;
            int counterMax = 0;
            int position = 0;
            for (int i = 0; i < result.Count-1; i++)
            {
                counter = result[i].Length + result[i + 1].Length;
                if (counter > counterMax)
                {
                    counterMax = counter;
                    position = i;
                }
            }

            Console.WriteLine(result[position]);
            Console.WriteLine(result[position+1]);
        }
    }
}
