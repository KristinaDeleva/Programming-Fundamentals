using System;

namespace Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char sym = char.Parse(Console.ReadLine());
            char sym1 = char.Parse(Console.ReadLine());
            char sym2 = char.Parse(Console.ReadLine());


            Console.Write($"{sym2}{sym1}{sym}");
        }
    }
}
