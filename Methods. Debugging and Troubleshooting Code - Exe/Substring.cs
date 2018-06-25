using System;

namespace Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            const char symbol = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    hasMatch = true;

                    int endIndex = count + 1;

                    if (endIndex + i > text.Length)
                    {
                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += count;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }

        }
    }
}
