using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] {' ', ',', '.', '?', '!' }, 
                StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string myString = text[i];
                bool palindrome = GetStatus(myString);

                if (palindrome)
                {
                    palindromes.Add(myString);
                }
            }

            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", palindromes));
        }

        static bool GetStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}
