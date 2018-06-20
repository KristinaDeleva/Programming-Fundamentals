using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string bol = Console.ReadLine();
            bool variable = Convert.ToBoolean(bol);

            if (variable)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
