using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int output = GetMax(first, second);
                Console.WriteLine(output);
            }

            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char output = GetMax(first, second);
                Console.WriteLine(output);
            }

            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string output = GetMax(first, second);
                Console.WriteLine(output);
            }
        }

        static int GetMax(int first, int second)
        {
            int num = 0;
            if (first >= second)
            {
                num = first;
            }
            else
            {
                num = second; 
            }
            return num;
        }

        static char GetMax(char first, char second)
        {
            char num = (char)0x00;
            if (first >= second)
            {
                num = first;
            }
            else
            {
                num = second;
            }
            return num;
        }

        static string GetMax(string first, string second)
        {
            string num = string.Empty;
            if (first.CompareTo(second) >= 0)
            {
                num = first;
            }
            else
            {
                num = second;
            }
            return num;
        }
    }
}
