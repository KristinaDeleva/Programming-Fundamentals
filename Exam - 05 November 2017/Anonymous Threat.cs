using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();
            string input = Console.ReadLine();

            while (input!="3:1")
            {
                string[] data = input.Split(' ');
                string command = data[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(data[1]);
                        int endIndex = int.Parse(data[2]);
                        startIndex = ValidateIndex(startIndex, elements.Count);
                        endIndex = ValidateIndex(endIndex, elements.Count);

                        string concatElements = "";
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatElements += elements[i];
                        }
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            elements.RemoveAt(startIndex);
                        }
                        elements.Insert(startIndex, concatElements);
                        break;
                    case "divide":
                        int index = int.Parse(data[1]);
                        int partitionCount = int.Parse(data[2]);

                        List<string> partitions = SplitedEqually(elements[index], partitionCount);
                        elements.RemoveAt(index);
                        elements.InsertRange(index, partitions);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", elements));
        }

        private static List<string> SplitedEqually(string word, int partitionCount)
        {
            int part = word.Length / partitionCount;
            List<string> result = new List<string>();
            while (word.Length>=part)
            {
                result.Add(word.Substring(0, part));
                word = word.Substring(part);
            }
            if (word!= "")
            {
                result.Add(word);
            }
            if (result.Count==partitionCount)
            {
                return result;
            }
            else
            {
                string concatLastTwoEl = result[result.Count - 2] + result[result.Count - 1];
                result.RemoveRange(result.Count - 2, 2);
                result.Add(concatLastTwoEl);
                return result;
            }
        }

        private static int ValidateIndex(int index, int length)
        {
            if (index<0)
            {
                index = 0;
            }
            if (index>length-1)
            {
                index = length - 1;
            }
            return index;
        }
    }
}
