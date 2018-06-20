using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] user = Console.ReadLine().Split(' ').ToArray();
                string ip = user[0];
                string userName = user[1];
                int duration = int.Parse(user[2]);
                if (!logs.ContainsKey(userName))
                {
                    logs.Add(userName,new SortedDictionary<string, int>());
                }
                if (!logs[userName].ContainsKey(ip))
                {
                    logs[userName].Add(ip, duration);
                }
                else
                {
                    logs[userName][ip] += duration;
                }
            }

            foreach (var users in logs)
            {
                var totalDuration = logs[users.Key].Values.Sum();
                var listOfIp = users.Value.Keys.ToList();
                Console.WriteLine($"{users.Key}: {totalDuration} [{string.Join(", ", listOfIp)}]");
            }
        }
    }
}
