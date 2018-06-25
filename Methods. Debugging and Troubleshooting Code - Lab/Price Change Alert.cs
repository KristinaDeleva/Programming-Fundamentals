using System;

namespace Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPrice = int.Parse(Console.ReadLine());
            double border = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPrice - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double different = Percentage(lastPrice, currentPrice);
                bool isSignificantDifference = GetDifferent(different, border);
                string message = Get(currentPrice, lastPrice, different, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        static string Get(double currentPrice, double lastPrice, double different, bool etherTrueOrFalse)
        {
            string result = string.Empty;

            if (different == 0)
            {
                result = string.Format($"NO CHANGE: {currentPrice}");
            }
            else if (!etherTrueOrFalse)
            {
                result = string.Format($"MINOR CHANGE: {lastPrice} to {currentPrice} ({different * 100:F2}%)");
            }
            else if (different > 0)
            {
                result = string.Format($"PRICE UP: {lastPrice} to {currentPrice} ({different * 100:F2}%)");
            }
            else if (different < 0)
                result = string.Format($"PRICE DOWN: {lastPrice} to {currentPrice} ({different * 100:F2}%)");

            return result;
        }

        static bool GetDifferent(double border, double price)
        {
            if (Math.Abs(border) >= price)
            {
                return true;
            }

            return false;
        }

        static double Percentage(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;

            return result;
        }
    }
}
