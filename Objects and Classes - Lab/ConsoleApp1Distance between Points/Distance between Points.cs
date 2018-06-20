using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = Point.GetPoint();
            Point p2 = Point.GetPoint();
            double distance = Point.CalculateDistance(p1, p2);
            Console.WriteLine($"{distance:f3}");
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point GetPoint()
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point point = new Point() { X = input[0], Y = input[1] };
            return point;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            double a = p1.X - p2.X;
            double b = p1.Y - p2.Y;
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return distance;
        }
    }
}
