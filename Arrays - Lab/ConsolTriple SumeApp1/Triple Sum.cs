using System;

namespace ConsolTriple_SumeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            int[] arr = new int[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                arr[i] = int.Parse(temp[i]);
            }

            bool none = true;

            for (int a = 0; a < arr.Length-1; a++)
            {
                for (int b = a+1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (arr[a] + arr[b] == arr[c])
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
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
