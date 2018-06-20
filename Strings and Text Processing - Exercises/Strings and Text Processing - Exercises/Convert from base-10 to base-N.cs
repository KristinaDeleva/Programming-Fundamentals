using System;
using System.Numerics;
using System.Text;

namespace Strings_and_Text_Processing___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long toBase = long.Parse(input[0]);
            BigInteger numberBaseTen = BigInteger.Parse(input[1]);

            string result = "";

            while (numberBaseTen > 0)
            {
                BigInteger remainder = numberBaseTen % toBase;
                result = remainder.ToString() + result;
                numberBaseTen /= toBase;
            }
            Console.WriteLine(result);
        }
    }
}
