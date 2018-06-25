using System;
using System.Numerics;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            long rests = wingFlaps / endurance;

            long second = rests * 5;
            double totalDistance = (wingFlaps / 1000) * distance;

            second += (wingFlaps / 100);


            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine($"{second} s.");

            //double amountOfMoney = double.Parse(Console.ReadLine());
            //int countOfStudents = int.Parse(Console.ReadLine());
            //double priceOfSabers = double.Parse(Console.ReadLine());
            //double priceOfRobes = double.Parse(Console.ReadLine());
            //double priceOfBelts = double.Parse(Console.ReadLine());

            //int freeBelts = countOfStudents / 6;

            //double totalSabersPrice = Math.Ceiling(countOfStudents + (countOfStudents * 0.1)) * priceOfSabers;
            //double totalRobesPrice = countOfStudents * priceOfRobes;
            //double totalBeltsPrice = (countOfStudents - freeBelts) * priceOfBelts;
            //double totalPrice = totalSabersPrice + totalRobesPrice + totalBeltsPrice;


            //if (totalPrice <= amountOfMoney)
            //{
            //    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            //}
            //else
            //{
            //    Console.WriteLine($"Ivan Cho will need {totalPrice - amountOfMoney:f2}lv more.");
            //}

        }
    }
}
