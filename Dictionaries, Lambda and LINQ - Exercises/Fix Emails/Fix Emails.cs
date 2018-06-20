using System;
using System.Collections.Generic;
using System.Linq;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mail = new Dictionary<string, string>();
            string name = "";
            string email = "";
            string commands = Console.ReadLine();

            while (commands != "stop")
            {
                name = commands;
                email = Console.ReadLine();
                if (!mail.ContainsKey(name))
                {
                    mail.Add(name, email);
                }
                
                commands = Console.ReadLine();
            }

            foreach (var pair in mail.Where(x => !x.Value.EndsWith(".us")
                && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
