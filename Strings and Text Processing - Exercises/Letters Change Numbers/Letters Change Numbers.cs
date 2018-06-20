using System;
using System.Collections.Generic;
using System.Linq;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            foreach (var str in input)
            {
                var firstLetter = str.First();
                var lastLetter = str.Last();

                double number = double.Parse(str.Substring(1, str.Length - 2));

                number = FirstLetterCalc(firstLetter, number);
                number = LastLetterCalc(lastLetter, number);

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }

        private static double LastLetterCalc(char lastLetter, double number)
        {
            if (char.IsUpper(lastLetter))
            {
                number -= lastLetter - 'A' + 1;
            }
            else if (char.IsLower(lastLetter))
            {
                number += lastLetter - 'a' + 1;
            }
            return number;
        }

        private static double FirstLetterCalc(char firstLetter, double number)
        {
            if (char.IsUpper(firstLetter))
            {
                number /= firstLetter - 'A' + 1;
            }
            else if (char.IsLower(firstLetter))
            {
                number *= firstLetter - 'a' + 1;
            }
            return number;
        }
    }
}
