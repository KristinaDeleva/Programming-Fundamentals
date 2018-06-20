using System;
using System.Collections.Generic;
using System.Linq;

namespace Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];
            List<int> ladyBug = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i >= 0 && i < size).ToList();

            foreach (var index in ladyBug)
            {
                field[index] = 1;//ladybug here
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] commandParts = line.Split(' ');//1 left 5
                int currentLadyBug = int.Parse(commandParts[0]);
                string direction = commandParts[1];
                int flyLength = int.Parse(commandParts[2]);
                if (direction == "left")
                {
                    flyLength *= -1; 
                }
                if (currentLadyBug < 0 ||currentLadyBug >= size)
                {
                    continue; // outside of field
                }
                if (field[currentLadyBug] == 0)
                {
                    continue; // no ladybug here
                }
                field[currentLadyBug] = 0;//fly away
                var nextIndexToLand = currentLadyBug;
                while (true)
                {
                    nextIndexToLand += flyLength;
                    if (nextIndexToLand<0||nextIndexToLand>=size)
                    {
                        break;
                    }
                    if (field[nextIndexToLand]==1) // there is a ladybug in this cell
                    {
                        continue;
                    }
                    field[nextIndexToLand] = 1;
                    break;//just landed
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
