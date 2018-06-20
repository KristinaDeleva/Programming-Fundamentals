using System;
using System.Linq;
namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word1 = Console.ReadLine().Split(' ').ToArray();
            string[] word2 = Console.ReadLine().Split(' ').ToArray();

            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[i] == word2[i])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[word1.Length-1-i] == word2[word2.Length-1-i])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }

            if (leftCount > rightCount)
            {
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }
        }
    }
}
