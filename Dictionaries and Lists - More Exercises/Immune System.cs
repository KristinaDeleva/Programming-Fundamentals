using System;
using System.Collections.Generic;

namespace Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHealth = int.Parse(Console.ReadLine());
            int health = startHealth;
            var virusesList = new List<string>();



            while (health > 0)
            {
                var input = Console.ReadLine();
                var virusStrenght = 0;
                var time = 0;

                if (input == "end")
                {
                    break;
                }

                if (!virusesList.Contains(input))
                {
                    virusesList.Add(input);
                    for (int i = 0; i < input.Length; i++)
                    {
                        virusStrenght += input[i];
                    }
                    virusStrenght /= 3;
                    time = virusStrenght * input.Length;
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        virusStrenght += input[i];
                    }
                    virusStrenght /= 3;
                    time = virusStrenght * input.Length / 3;
                }

                health -= time;
                var minutes = time / 60;
                var seconds = time - minutes * 60;

                Console.WriteLine($"Virus {input}: {virusStrenght} => {time} seconds");
                if (health <= 0)
                {
                    break;
                }

                Console.WriteLine($"{input} defeated in {minutes}m {seconds}s.");
                Console.WriteLine($"Remaining health: {health}");


                health += health * 20 / 100;
                if (health > startHealth)
                {
                    health = startHealth;
                }
            }

            if (health > 0)
            {
                Console.WriteLine($"Final Health: {health}");
            }
            else
            {
                Console.WriteLine($"Immune System Defeated.");
            }
        }
    }
}
