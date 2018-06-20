using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> site = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string user;
            string ip;
            while (input[0] != "end")
            {
                string[] ipInput = input[0].Split('=').ToArray();
                ip = ipInput[1];
                string[] userInput = input[2].Split('=').ToArray();
                user = userInput[1];
                if (!site.ContainsKey(user))
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(ip, 1);
                    site.Add(user, current);
                }
                else
                {
                    if (!site[user].ContainsKey(ip))
                    {
                        site[user].Add(ip, 1);
                    }
                    else
                    {
                        site[user][ip]++;
                    }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var currentUser in site.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{currentUser.Key}: ");
                List<string> helper = new List<string>();
                foreach (var ipPair in currentUser.Value)
                {
                    helper.Add($"{ipPair.Key} => { ipPair.Value}");
                }
                Console.WriteLine(string.Join(", ", helper) + ".");
            }
        }
    }
}
