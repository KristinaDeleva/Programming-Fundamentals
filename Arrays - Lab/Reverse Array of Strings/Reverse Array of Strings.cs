using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] arr = text.Split(' ').ToArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
