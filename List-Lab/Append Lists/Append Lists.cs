using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textList = Console.ReadLine().Split('|').ToList();

            textList.Reverse();

            foreach (var text in textList)
            {
                var textArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var joined = string.Join(" ", textArr);
                Console.Write(joined + " ");
            }
            Console.WriteLine();
        }
    }
}
