using System;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string message = "";
            bool canFit = false;

            try
            {
                sbyte num = sbyte.Parse(number);
                message += "* sbyte\r\n";
                canFit = true;
            }
            catch{}
            try
            {
                byte num = byte.Parse(number);
                message += "* byte\r\n";
                canFit = true;
            }
            catch {}
            try
            {
                short num = short.Parse(number);
                message += "* short\r\n";
                canFit = true;
            }
            catch {}
            try
            {
                ushort num = ushort.Parse(number);
                message += "* ushort\r\n";
                canFit = true;
            }
            catch {}
            try
            {
                int num = int.Parse(number);
                message += "* int\r\n";
                canFit = true;
            }
            catch {}
            try
            {
                uint num = uint.Parse(number);
                message += "* uint\r\n";
                canFit = true;
            }
            catch {}
            try
            {
                long num = long.Parse(number);
                message += "* long\r\n";
                canFit = true;
            }
            catch {}

            if (canFit)
            {
                Console.WriteLine($"{number} can fit in:");
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
