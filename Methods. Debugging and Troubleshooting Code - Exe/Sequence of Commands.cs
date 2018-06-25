using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_of_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] arg = command
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                PerformAction(args, array);

                Console.WriteLine(string.Join(" ", array));

                command = Console.ReadLine();
            }
        }

        static void PerformAction(string[] args, long[] array)
        {
            string action = args[0];

            if (args.Length > 1)
            {
                int index = int.Parse(args[1]) - 1;
                int value = int.Parse(args[2]);
                switch (action)
                {
                    case "add":
                        array[index] += value;
                        break;
                    case "subtract":
                        array[index] -= value;
                        break;
                    case "multiply":
                        array[index] *= value;
                        break;
                }
            }
            else if (args[0] == "lshift")
            {
                ArrayShiftLeft(array);
            }
            else if (args[0] == "rshift")
            {
                ArrayShiftRight(array);
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastNumber = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastNumber;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstNumber = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstNumber;
        }
    }
}

    

