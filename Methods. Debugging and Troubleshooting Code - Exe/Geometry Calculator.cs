using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            switch (figure)
            {
                case "triangle":
                    TriangleArea();
                    break;
                case "square":
                    SquareCalc();
                    break;
                case "rectangle":
                    RectangleArea();
                    break;
                case "circle":
                    CircleArea();
                    break;
            }
        }

        private static void CircleArea()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"{area:f2}");
        }

        private static void RectangleArea()
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = widht * height;
            Console.WriteLine($"{area:f2}");
        }

        private static void SquareCalc()
        {
            double side = double.Parse(Console.ReadLine());
            double area = Math.Pow(side, 2);
            Console.WriteLine($"{area:f2}");
        }

        private static void TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
