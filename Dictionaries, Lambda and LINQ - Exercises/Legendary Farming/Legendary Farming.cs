using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shadowmourne = false;
            bool valanyr = false;
            bool dragonwrath = false;
            string resource;
            int quantity = 0;
            Dictionary<string, int> resourcesPrimary = new Dictionary<string, int>();
            resourcesPrimary.Add("shards", 0);
            resourcesPrimary.Add("fragments", 0);
            resourcesPrimary.Add("motes", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string prize = "";
            while (shadowmourne == false && valanyr == false && dragonwrath == false)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                for (int i = 0; i < input.Length; i+=2)
                {
                    resource = input[i + 1].ToLower();
                    quantity = int.Parse(input[i]);
                    if (resourcesPrimary.ContainsKey(resource))
                    {
                        resourcesPrimary[resource] += quantity;
                    }
                    else if (!junk.ContainsKey(resource))
                    {
                        junk.Add(resource, quantity);
                    }
                    else
                    {
                        junk[resource] += quantity;
                    }

                    if (resourcesPrimary["shards"] >= 250)
                    {
                        shadowmourne = true;
                        prize = "Shadowmourne";
                        resourcesPrimary["shards"] -= 250;
                        break;
                    }
                    else if (resourcesPrimary["fragments"] >= 250)
                    {
                        valanyr = true;
                        prize = "Valanyr";
                        resourcesPrimary["fragments"] -= 250;
                        break;
                    }
                    else if (resourcesPrimary["motes"] >= 250)
                    {
                        dragonwrath = true;
                        prize = "Dragonwrath";
                        resourcesPrimary["motes"] -= 250;
                        break;
                    }
                }
            }

            Console.WriteLine($"{prize} obtained!");

            foreach (var metal in resourcesPrimary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{metal.Key}: {metal.Value}");
            }
            foreach (var metal in junk.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{metal.Key}: {metal.Value}");
            }
        }
    }
}
