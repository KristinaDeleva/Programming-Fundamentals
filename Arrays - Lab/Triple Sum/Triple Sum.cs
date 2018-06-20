using System;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            bool none = true;

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] == arr[k])
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} = {arr[k]}");
                            none = false;
                            break;
                        }
                    }
                }
            }

            if (none)
            {
                Console.WriteLine("No");
            }
        }
    }
}
