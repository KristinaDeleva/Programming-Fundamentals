using System;
using System.Linq;

namespace p02
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] result = new int[count];
            int bestLenght = 0;
            int bestIndex = 0;
            int seqIndex = 1;
            int counter = 1;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                int[] currSeq = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int currLenght = 0;
                int startIndex = 0;

                for (int i = 0; i < currSeq.Length; i++)
                {
                    if (currSeq[i] == 1)
                    {
                        currLenght++;
                        if (currLenght > bestLenght)
                        {
                            result = currSeq;
                            bestIndex = startIndex;
                            bestLenght = currLenght;
                            seqIndex = counter;
                        }
                        else if (currLenght == bestLenght)
                        {
                            if (startIndex < bestIndex)
                            {
                                result = currSeq;
                                bestIndex = startIndex;
                                bestLenght = currLenght;
                                seqIndex = counter;
                            }
                            else if (startIndex == bestIndex && currSeq.Sum() > result.Sum())
                            {
                                result = currSeq;
                                bestIndex = startIndex;
                                bestLenght = currLenght;
                                seqIndex = counter;
                            }
                        }
                    }
                    else
                    {
                        currLenght = 0;
                        startIndex = i + 1;
                    }
                }
                counter++;
            }

            Console.WriteLine($"Best DNA sample {seqIndex} with sum: {result.Sum()}.");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
