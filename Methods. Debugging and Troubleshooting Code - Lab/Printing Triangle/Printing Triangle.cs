using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = int.Parse(Console.ReadLine());
            PrintTop(cols);

            PrintBottom(cols);

            //PrintTriangle(int.Parse(Console.ReadLine()));
        }

        private static void PrintBottom(int cols)
        {
            for (int row = cols - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintTop(int cols)
        {
            for (int row = 1; row <= cols; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        //static void PrintLine(int start, int end)
        //{
        //    for (int i = start; i <= end; i++)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();
        //}

        //static void PrintTriangle(int n)
        //{
        //    for (int line = 1; line <= n; line++)
        //    {
        //        PrintLine(1, line);
        //    }
        //    for (int line = n - 1; line >= 1; line--)
        //    {
        //        PrintLine(1, line);
        //    }
        //}
    }
}
