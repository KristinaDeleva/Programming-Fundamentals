using System;
using System.Linq;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNum = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();
            int[] secondNum = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();

            int firstLenght = firstNum.Length;
            int secondLenght = secondNum.Length;
            int maxLenght = Math.Max(firstNum.Length, secondNum.Length);

            int[] sumOfNum = new int[maxLenght];

            for (int i = 0; i < maxLenght; i++)
            {
                sumOfNum[i] = firstNum[i % firstLenght] + secondNum[i % secondLenght];
            }

            Console.WriteLine(string.Join(" ", sumOfNum));
        }
    }
}
