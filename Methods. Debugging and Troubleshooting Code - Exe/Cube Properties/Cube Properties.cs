using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();

            switch (parameter)
            {
                case "face": CubeFaceDiagonals(side);
                    break;
                case "space": CubeSpaceDiagonals(side);
                    break;
                case "volume": CubeVolume(side);
                    break;
                case "area": CubeSurfaceArea(side);
                    break;
                default:
                    break;
            }
        }

        static void CubeFaceDiagonals(double side)
        {
            Console.WriteLine($"{Math.Sqrt(2 * (side * side)):f2}");
        }

        static void CubeSpaceDiagonals(double side)
        {
            Console.WriteLine($"{Math.Sqrt(3 * (side * side)):f2}");
        }

        static void CubeVolume(double side)
        {
            Console.WriteLine($"{side * side * side:f2}");
        }

        static void CubeSurfaceArea(double side)
        {
            Console.WriteLine($"{6 * (side * side):f2}");
        }


    }
}
