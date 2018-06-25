using System;
using System.Linq;

namespace Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            string[] jewelsAndGold = Console.ReadLine().Split().ToArray();
            long jewlsPrice = long.Parse(jewelsAndGold[0]);
            long goldPrice = long.Parse(jewelsAndGold[1]);

            string loot = "";
            long expenses = 0;
            long totalExpenses = 0;
            long totalProfit = 0;
            while (true)
            {
                string heist = Console.ReadLine();
                if (heist == "Jail Time")
                {
                    break;
                }
                string[] lootAndExpenses = heist.Split().ToArray();
                loot = lootAndExpenses[0];
                expenses = long.Parse(lootAndExpenses[1]);
                totalExpenses += expenses;
                totalProfit += CountingProfit(jewlsPrice, goldPrice, loot);
            }
            PrintOutput(totalProfit, totalExpenses);
        }

        static long CountingProfit(long jewlsPrice, long goldPrice, string loot)
        {

            long totalProfit = 0;
            foreach (var element in loot)
            {
                if (element == '%')
                {
                    totalProfit += jewlsPrice;
                }
                if (element == '$')
                {
                    totalProfit += goldPrice;
                }
            }
            return totalProfit;
        }

        static void PrintOutput(long totalProfit, long totalExpenses)
        {
            if (totalProfit >= totalExpenses)
            {
                Console.WriteLine
                    ($"Heists will continue. Total earnings: {totalProfit - totalExpenses}.");
            }
            else
            {
                Console.WriteLine
                    ($"Have to find another job. Lost: {totalExpenses - totalProfit}.");
            }
        }
    }
}
 