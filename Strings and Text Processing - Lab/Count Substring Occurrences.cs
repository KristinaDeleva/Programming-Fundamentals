using System;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            int index = -1;
            while (true)
            {
                index = text.IndexOf(pattern, index + 1);

                if (index == -1)
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
