using System;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            int securityToken = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            for (int i = 0; i < numberOfWebsites; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string siteName = input[0];
                decimal siteVisits = decimal.Parse(input[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(input[2]);

                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalLoss += siteLoss;
                Console.WriteLine(siteName);
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityToken,numberOfWebsites)}");

        }
    }
}
