using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] resultArr = new int[input.Length]; //копие на входящия arr и после пази крайния резултат
            Array.Copy(input, resultArr, input.Length);
            int[] tempArr = new int[input.Length];

            string[] command = Console.ReadLine().Split(' ').Select(x => x.Trim()).ToArray();
            int indexResult = 0;


            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if (index > resultArr.Length - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine().Split(' ').ToArray();
                        continue;
                    }
                    Array.Copy(resultArr, index + 1, tempArr, 0, (resultArr.Length - (index + 1)));
                    Array.Copy(resultArr, 0, tempArr, (resultArr.Length - (index + 1)), index + 1);
                    Array.Copy(tempArr, resultArr, resultArr.Length);
                    // Console.WriteLine("[" + string.Join(", ", inputArray) + "]"); // позлвам да си проверя дали е ок резултата
                }
                if (command[0] == "max" || command[0] == "min")
                {


                    if (command[1] == "even")
                    {
                        bool allOdd = resultArr.All(x => x % 2 != 0);

                        if (allOdd)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine().Split(' ').ToArray();
                            continue;
                        }
                    }
                    if (command[1] == "odd")
                    {
                        bool allEven = resultArr.All(x => x % 2 == 0);

                        if (allEven)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine().Split(' ').ToArray();
                            continue;
                        }
                    }
                    if (command[0] == "max" && command[1] == "even")
                    {
                        indexResult = resultArr.Select(x => x).Where(x => x % 2 == 0).OrderByDescending(y => y).First();
                    }
                    else if (command[0] == "max" && command[1] == "odd")
                    {
                        indexResult = resultArr.Select(x => x).Where(x => x % 2 != 0).OrderByDescending(y => y).First();

                    }
                    else if (command[0] == "min" && command[1] == "even")
                    {
                        indexResult = resultArr.Select(x => x).Where(x => x % 2 == 0).OrderByDescending(y => y).Last();

                    }
                    else if (command[0] == "min" && command[1] == "odd")
                    {
                        indexResult = resultArr.Select(x => x).Where(x => x % 2 != 0).OrderByDescending(y => y).Last();

                    }
                    int maxIndex = resultArr.ToList().LastIndexOf(indexResult);
                    Console.WriteLine(maxIndex);
                }
                if (command[0] == "first" || command[0] == "last")
                {
                    var resultList = new List<int>();
                    var count = int.Parse(command[1]);
                    bool allEqual = resultArr.Skip(1).All(s => int.Equals(resultArr[0], s));

                    if (count > resultArr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine().Split(' ').ToArray();
                        continue;
                    }
                    if (command[0] == "first" && command[2] == "even")
                    {
                        resultList = resultArr.Select(x => x).Where(x => x % 2 == 0).Take(count).ToList();
                    }
                    else if (command[0] == "first" && command[2] == "odd")
                    {
                        resultList = resultArr.Select(x => x).Where(x => x % 2 != 0).Take(count).ToList();
                    }
                    else if (command[0] == "last" && command[2] == "even")
                    {
                        resultList = resultArr.Select(x => x).Where(x => x % 2 == 0).Reverse().Take(count).Reverse().ToList();
                    }
                    else if (command[0] == "last" && command[2] == "odd")
                    {
                        resultList = resultArr.Select(x => x).Where(x => x % 2 != 0).Reverse().Take(count).Reverse().ToList();
                    }
                    Console.WriteLine("[" + string.Join(", ", resultList) + "]");
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine("[" + string.Join(", ", resultArr) + "]");

        }
    }
}
