using System;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long marathonDay = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int averageLapsPerRunners = int.Parse(Console.ReadLine());
            long track = long.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            long maximumRunners = capacity * marathonDay;
            runners = Math.Min(maximumRunners, runners);
            long totalMeters = runners * averageLapsPerRunners * track;
            long totalKm = totalMeters / 1000;
            double money = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: { money:f2}");
        }
    }
}
