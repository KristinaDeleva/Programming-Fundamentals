using System;

namespace Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }

        private static void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
