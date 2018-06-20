using System;
using System.Linq;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] commandsPart = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                switch (commandsPart[0])
                {
                    case "reverse":
                        int start = int.Parse(commandsPart[2]);
                        int count = int.Parse(commandsPart[4]);
                        arr = Reverse(arr, start, count);
                        break;
                    case "sort":
                        start = int.Parse(commandsPart[2]);
                        count = int.Parse(commandsPart[4]);
                        arr = Sort(arr, start, count);
                        break;
                    case "rollLeft":
                        count = int.Parse(commandsPart[1]);
                        arr = RollLeft(arr, count);
                        break;
                    case "rollRight":
                        count = int.Parse(commandsPart[1]);
                        arr = RollRight(arr, count);
                        break;
                    
                }
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static string[] RollRight(string[] arr, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return arr;
            }

            count %= arr.Length;

            string[] firstPart = arr.Skip(arr.Length - count).ToArray();
            string[] secondPart = arr.Take(arr.Length - count).ToArray();

            return firstPart.Concat(secondPart).ToArray();
        }

        static string[] RollLeft(string[] arr, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return arr;
            }

            count %= arr.Length;
            string[] firstPart = arr.Take(count).ToArray();
            string[] secondPart = arr.Skip(count).ToArray();

            return secondPart.Concat(firstPart).ToArray();
        }

        static string[] Sort(string[] arr, int start, int count)
        {
            if (start < 0 || start >= arr.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return arr;
            }

            if (start + count < 0 || count < 0 || start + count - 1 >= arr.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return arr;
            }

            string[] firstPart = arr.Take(start).ToArray();
            string[] sortedPart = arr.Skip(start).Take(count).OrderBy(s=>s).ToArray();
            string[] lastPart = arr.Skip(start + count).ToArray();

            return firstPart.Concat(sortedPart).Concat(lastPart).ToArray();
        }

        static string[] Reverse(string[] arr, int start, int count)
        {
            if (start < 0||start >= arr.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return arr;
            }
            if (start + count < 0||count < 0||start + count - 1 >= arr.Length)
            {
                Console.WriteLine("Invalid input parameters.");
                return arr;
            }

            string[] firstPart = arr.Take(start).ToArray();
            string[] reversedPart = arr.Skip(start).Take(count).Reverse().ToArray();
            string[] lastPart = arr.Skip(start+count).ToArray();

            return firstPart.Concat(reversedPart).Concat(lastPart).ToArray();
        }
    }
}
