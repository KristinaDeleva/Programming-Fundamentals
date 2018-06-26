using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Snowmen
{
    class Snowmen
    {
        static void Main(string[] args)
        {
            var surface =new Regex (@"^[^A-Za-z0-9]+$");
            var mantle = new Regex(@"^[^0-9_]+$");
            var middle = new Regex (@"^[^A-Za-z0-9]+[0-9_]+(?<core>[A-Za-z])[0-9_]+[^A-Za-z0-9]+$");
            int lenght = 0;

            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();
                if (i == 0 || i == 4)
                {
                    Validate(surface, line);
                }
                else if (i == 1 || i == 3)
                {
                    Validate(mantle, line);
                }
                else 
                {
                    Validate(middle, line);
                    Match match = middle.Match(line);

                    lenght = match.Groups["core"].Length;
                }
            }

            Console.WriteLine("Valid");
            Console.WriteLine(lenght);
            //try
            //{
            //    List<int> listOfNumbers = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToList();

            //    // 0  1  2 3 4 5 6  => 7
            //    // 25 31 6 9 2 4 7

            //    List<int> loserList = new List<int>();

            //    while (listOfNumbers.Count != 1)
            //    {
            //        for (int index = 0; index < listOfNumbers.Count; index++)
            //        {
            //            if (Math.Abs(loserList.Count - listOfNumbers.Count) == 1)
            //            {
            //                continue;
            //            }

            //            if (loserList.Contains(index))
            //            {
            //                continue;
            //            }

            //            int attackerIndex = index;
            //            int targteIndex = ValidIndex(listOfNumbers[attackerIndex], listOfNumbers.Count);
            //            int absoluteValue = Math.Abs(attackerIndex - targteIndex);

            //            if (absoluteValue == 0)
            //            {
            //                Console.WriteLine($"{attackerIndex} performed harakiri");
            //                loserList.Add(attackerIndex);
            //                loserList = loserList.Distinct().ToList();
            //            }

            //            if (absoluteValue != 0 && absoluteValue % 2 == 0)
            //            {
            //                Console.WriteLine($"{attackerIndex} x {targteIndex} -> {attackerIndex} wins");
            //                loserList.Add(targteIndex);
            //                loserList = loserList.Distinct().ToList();
            //            }

            //            if (absoluteValue % 2 == 1)
            //            {
            //                Console.WriteLine($"{attackerIndex} x {targteIndex} -> {targteIndex} wins");
            //                loserList.Add(attackerIndex);
            //                loserList = loserList.Distinct().ToList();
            //            }
            //        }

            //        foreach (var index in loserList.OrderByDescending(x => x).Distinct())
            //        {
            //            listOfNumbers.RemoveAt(index);
            //        }

            //        loserList.Clear();
            //    }
            //}
            //catch
            //{

            //}
        }

        private static void Validate(Regex regex, string line)
        {
            if (regex.IsMatch(line) == false)
            {
                Console.WriteLine("Invalid");
                Environment.Exit(0);
            }
        }

        //static int ValidIndex(int index, int lenght)
        //{
        //    if (index >= lenght)
        //    {
        //        index = index % lenght;
        //    }
        //    return index;
        //}
    }
}
