using System;
using System.Collections.Generic;
using System.Linq;

namespace p05
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> forceUsers = new Dictionary<string, string>();
            Dictionary<string, int> forceSides = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                string[] inputArr = new string[3];
                if (input.Contains(" | "))
                {
                    inputArr = input.Split(" | ");

                    if (forceUsers.ContainsKey(inputArr[1]) == false)
                    {
                        forceUsers.Add(inputArr[1], inputArr[0]);
                    }
                    if (forceSides.ContainsKey(inputArr[0]) == false)
                    {
                        forceSides.Add(inputArr[0], 0);
                    }
                    forceSides[inputArr[0]]++;
                }
                else if (input.Contains("->"))
                {
                    inputArr = input.Split("->");
                    if (forceUsers.ContainsKey(inputArr[0]) == false)
                    {
                        forceUsers.Add(inputArr[0], inputArr[1]);
                    }
                    if (forceSides.ContainsKey(inputArr[1]) == false)
                    {
                        forceSides.Add(inputArr[1], 0);
                    }
                    forceSides[inputArr[1]]++;
                }
                else
                {
                    forceSides[forceUsers[inputArr[0]]]--;
                    if (forceSides.ContainsKey(inputArr[1]) == false)
                    {
                        forceSides.Add(inputArr[1], 0);
                    }
                    forceSides[inputArr[1]]++;

                    forceUsers[inputArr[0]] = inputArr[1];
                }

                Console.WriteLine($"{inputArr[0]} joins the {inputArr[1]} side!");
            }

            foreach (var side in forceSides.OrderByDescending(x=>x.Value)
                .ThenBy(x=>x.Key))
            {
                if (side.Value > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value}");

                    foreach (var user in forceUsers.Where(x=>x.Value == side.Key).OrderBy(x=>x.Key))
                    {
                        Console.WriteLine($"! {user.Key}");
                    }
                }
            }
            //var result = new Dictionary<string, List<string>>();
            //List<string> users = new List<string>();

            //while (true)
            //{
            //    string input = Console.ReadLine();

            //    if (input == "Lumpawaroo")
            //    {
            //        break;
            //    }

            //    if (input.Contains("|"))
            //    {
            //        string side = input.Split(" | ")[0];
            //        string name = input.Split(" | ")[1];

            //        if (!result.ContainsKey(side))
            //        {
            //            if (!users.Contains(name))
            //            {
            //                result.Add(side, new List<string>() { name });
            //                result[side] = result[side].OrderBy(n => n).ToList();
            //                users.Add(name);
            //            }


            //        }

            //        else
            //        {
            //            if (!result[side].Contains(name))
            //            {
            //                result[side].Add(name);
            //                result[side] = result[side].OrderBy(n => n).ToList();
            //                users.Add(name);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        string name = input.Split(" -> ")[0];
            //        string side = input.Split(" -> ")[1];

            //        if (users.Contains(name))
            //        {
            //            var currSideName = result.First(s => s.Value.Contains(name)).Key;
            //            result[currSideName].Remove(name);

            //            if (!result.ContainsKey(side))
            //            {
            //                result.Add(side, new List<string>() { name });
            //                users.Add(name);
            //                result[side] = result[side].OrderBy(n => n).ToList();
            //                Console.WriteLine($"{name} joins the {side} side!");
            //            }

            //            else
            //            {
            //                result[side].Add(name);
            //                users.Add(name);
            //                result[side] = result[side].OrderBy(n => n).ToList();
            //                Console.WriteLine($"{name} joins the {side} side!");
            //            }
            //        }

            //        else if (!result.ContainsKey(side))
            //        {
            //            result.Add(side, new List<string>() { name });
            //            users.Add(name);
            //            result[side] = result[side].OrderBy(n => n).ToList();
            //            Console.WriteLine($"{name} joins the {side} side!");
            //        }

            //        else
            //        {
            //            result[side].Add(name);
            //            result[side] = result[side].OrderBy(n => n).ToList();
            //            Console.WriteLine($"{name} joins the {side} side!");
            //        }
            //    }
            //}

            //result = result.Where(kvp => kvp.Value.Count > 0).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            //foreach (var side in result.OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => kvp.Key))
            //{
            //    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

            //    foreach (var name in side.Value.OrderBy(n => n))
            //    {
            //        Console.WriteLine($"! {name}");
            //    }
            //}
        }
    }
}
