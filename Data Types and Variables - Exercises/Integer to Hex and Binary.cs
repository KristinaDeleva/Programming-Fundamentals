using System;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            string hexa = Convert.ToString(number, 16).ToUpper();

            Console.WriteLine(hexa);
            Console.WriteLine(binary);
        }
    }
}
