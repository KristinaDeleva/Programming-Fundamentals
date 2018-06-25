using System;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            long[] arr = new long[num1];
            arr[0] = 1;

            for (int i = 1; i < num1; i++)
            {
                long sum = 0;

                for (int j = i - num2; j < i; j++)
                {
                    if (j >= 0)
                    {
                        sum += arr[j];
                        arr[i] = sum;
                    }
                }
            }

            for (int i = 0; i < num1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
