using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> forceUser = new Dictionary<string,string>();
            string[] input = Console.ReadLine().Split('|').ToArray();
            string[] forceSide = Console.ReadLine().Split('|').ToArray(); 
            string count = "";
            
            while (input[0] != "Lumpawaroo")
            {               
                count = input[0];
                if (!forceUser.ContainsKey(forceSide))
                {
                    forceUser.Add(forceSide, count);
                }
                
                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var pair in forceUser.OrderByDescending(x => x))
            {
                Console.WriteLine($"Side: {forceSide}, Members: {forceUser.Count}");
                Console.WriteLine($"! {forceUser}");
            }
        }
    }
}
