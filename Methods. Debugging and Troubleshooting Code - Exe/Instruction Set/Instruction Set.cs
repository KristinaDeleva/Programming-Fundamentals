using System;

namespace Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {

            string opCode = Console.ReadLine();
            long result = 0;

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');
                bool isCommand = true;

                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                    default: isCommand = false;
                        break;
                }
                if (isCommand)
                {
                    Console.WriteLine(result);
                }
                
                opCode = Console.ReadLine();
            }

            
        }
    }
}
    

