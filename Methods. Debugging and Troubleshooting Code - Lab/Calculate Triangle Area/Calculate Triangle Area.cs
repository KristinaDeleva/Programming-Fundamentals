using System;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleArea(widht,height);
            Console.WriteLine(area);

        }

        static double TriangleArea(double widht, double height)
        {
            double area = widht * height / 2;
            return area;
        }
    }
}
