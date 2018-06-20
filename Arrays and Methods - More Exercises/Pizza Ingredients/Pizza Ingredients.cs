using System;
using System.Linq;
using System.Collections.Generic;
namespace Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int searchedLenght = int.Parse(Console.ReadLine());
            int count = 0;
            var addIngredients = new List<string>();

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == searchedLenght)
                {
                    count++;
                    addIngredients.Add(ingredients[i]); 
                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
                if (count >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",addIngredients)}.");
        }
    }
}
