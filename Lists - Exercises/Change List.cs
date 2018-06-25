using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    numbers.RemoveAll(num => num == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    int elements = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, elements);
                }

                commands = Console.ReadLine().Split(' ').ToArray();
            }

            if (commands[0] == "Odd")
            {
                numbers.RemoveAll(x => x % 2 == 0);
            }
            else if (commands[0] == "Even")
            {
                numbers.RemoveAll(x => x % 2 == 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
