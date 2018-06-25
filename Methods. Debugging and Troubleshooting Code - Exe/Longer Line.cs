using System;
using System.Globalization;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double z1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double z2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double m1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double m2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if ((Math.Abs(x1 - y1)) >= (Math.Abs(z1 - m1)) && (Math.Abs(x2 - y2)) >= (Math.Abs(z2 - m2)))
            {

                coordinats(x1, x2, y1, y2);
            }
            else
            {

                coordinats(z1, z2, m1, m2);
            }
        }
        static void coordinats(double x1, double x2, double y1, double y2)
        {
            double firstDiagonal = Math.Pow(x1, 2) + Math.Pow(x2, 2);
            double secondDiagonal = Math.Pow(y1, 2) + Math.Pow(y2, 2);
            if (secondDiagonal >= firstDiagonal)
            {
                Console.Write("({0}, {1})", x1, x2);
                Console.WriteLine("({0}, {1})", y1, y2);
            }
            else
            {
                Console.Write("({0}, {1})", y1, y2);
                Console.WriteLine("({0}, {1})", x1, x2);
            }
        }
    }
}

