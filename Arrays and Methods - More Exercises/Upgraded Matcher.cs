using System;
using System.Collections.Generic;
using System.Linq;

namespace Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsInput = Console.ReadLine().Split();
            List<long> productsQuantity = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            decimal[] productsPrice = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();
            string[] orderedProduct = Console.ReadLine().Split();

            while (productsQuantity.Count < productsInput.Length)
            {
                productsQuantity.Add(0);
            }

            while (orderedProduct[0] != "done")
            {
                bool flagInside = false;
                for (int i = 0; i < productsInput.Length; i++)
                {
                    long orderedQuantity = long.Parse(orderedProduct[1]);
                    if (orderedProduct[0] == productsInput[i]
                        && orderedQuantity <= productsQuantity[i])
                    {
                        productsQuantity[i] -= orderedQuantity;
                        var price = productsPrice[i] * orderedQuantity;
                        Console.WriteLine
                            ($"{productsInput[i]} x {orderedQuantity} costs {price:f2}");
                        flagInside = true; break;
                    }
                }

                if (!flagInside)
                    Console.WriteLine($"We do not have enough {orderedProduct[0]}");

                orderedProduct = Console.ReadLine().Split();
            }
        }
    }
}
