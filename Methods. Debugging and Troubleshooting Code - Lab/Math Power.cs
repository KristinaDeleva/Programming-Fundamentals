using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(num, power));
        }

        static double RaiseToPower(double number,int power)
        {
            double result = 0;
            result = Math.Pow(number, power);
            return result;
        }
    }
}
