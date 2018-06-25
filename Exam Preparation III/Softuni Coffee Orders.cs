using System;
using System.Globalization;

namespace Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < numbersOfOrders; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(),
                    "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal orderPrice = (daysInMonth * capsules) * price;
                totalPrice += orderPrice;
                Console.WriteLine($"The price for the coffee is: {orderPrice:f2}");
            }

            Console.WriteLine($"Total: {totalPrice:f2}");
        }
    }
}
