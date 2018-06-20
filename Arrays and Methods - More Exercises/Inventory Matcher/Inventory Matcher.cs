using System;
using System.Linq;

namespace Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split(' ');
            long[] quantity = Console.ReadLine().Split(' ').
                Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').
                Select(decimal.Parse).ToArray();
            string newProduct = Console.ReadLine();

            while (newProduct != "done")
            {
                FindingProduct(name, quantity, price, newProduct);
                newProduct = Console.ReadLine();
            }
            
        }

        private static void FindingProduct(string[] name, long[] quantity, decimal[] price, string newProduct)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (newProduct == name[i])
                {
                    Console.WriteLine($"{name[i]} costs: {price[i]}; Available quantity: {quantity[i]}");
                    break;
                }
            }
        }
    }
}
