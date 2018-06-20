using System;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write("\\u{0:x4}", (int)symbol);
            }
            Console.WriteLine();
        }
    }
}
