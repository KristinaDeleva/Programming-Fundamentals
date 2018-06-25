using System;

namespace Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeared();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeared()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
