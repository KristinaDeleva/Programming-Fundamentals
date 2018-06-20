using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMax();
        }

        static void GetMax()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Math.Max(Math.Max(a, b), c);

            Console.WriteLine(result);
        }
    }
}
