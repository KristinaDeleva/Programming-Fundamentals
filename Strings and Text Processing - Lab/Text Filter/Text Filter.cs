using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] badWords = Console.ReadLine().Split(new char[] {',',' ' }, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var badWord in badWords)
            {
                text = text.Replace(badWord, new string('*', badWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
