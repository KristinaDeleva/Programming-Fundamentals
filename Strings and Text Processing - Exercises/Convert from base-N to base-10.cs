using System;
using System.Numerics;
using System.Text;

namespace Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long toBase = long.Parse(input[0]);

            string number = input[1];

            BigInteger result = 0;

            int power = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                BigInteger num = BigInteger.Parse(number[i].ToString());
                result += BigInteger.Multiply(num, BigInteger.Pow(toBase, power));
                power--;
            }

            Console.WriteLine(result);
        }
    }
}
