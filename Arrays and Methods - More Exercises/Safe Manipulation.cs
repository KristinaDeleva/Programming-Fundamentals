using System;
using System.Linq;
namespace Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] manipulatedArray = input;
            int lengthArr = manipulatedArray.Length;


            string[] command = Console.ReadLine().Split(' ');


            while (command[0] != "END")
            {
                string action = command[0];


                if (action == "Reverse")
                {
                    manipulatedArray = manipulatedArray.Reverse().ToArray();
                }
                else if (action == "Distinct")
                {

                    manipulatedArray = manipulatedArray.Distinct().ToArray();
                    lengthArr = manipulatedArray.Count();

                }
                else if (action == "Replace")

                {
                    int index = int.Parse(command[1]);
                    string wordToChange = command[2];

                    if (index > lengthArr - 1 || (index < 0))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        manipulatedArray[index] = wordToChange;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(String.Join(", ", manipulatedArray));
        }
    }
}
