using System;

namespace Exam_Preparation_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            int numberOfGuest = int.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            int portions =(int)Math.Ceiling(numberOfGuest / 6.0);
            decimal neededProducts = (2m * priceOfBananas) + (4m * priceOfEggs) + (0.2m * priceOfBerries);
            decimal neededMoney =(decimal) portions * neededProducts;

            if (neededMoney <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
            }
            else 
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney - amountOfCash:f2}lv more.");
            }
        }
    }
}
