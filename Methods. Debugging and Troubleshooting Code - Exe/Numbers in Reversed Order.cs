using System;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Въвеждаме числото и създаваме необходимите променливи
            decimal n = decimal.Parse(Console.ReadLine());
            int places = 0;
            int times = 0;
            decimal reversed = 0;

            //  Намираме броя знаци след десетичната запетая и привеждаме до цяло число
            while (n % 1 > 0)
            {
                n *= 10;
                places++;
            }

            //  Обръщаме реда на цифрите в цялото число и запазваме броя им
            do
            {
                int remainder = (int)n % 10;
                reversed = reversed * 10 + remainder;
                n = (int)n / 10;
                times++;
            }
            while (n > 0);

            //  Ако въведеното число е имало дробна част, разделяме така че да получим обърнат вариант на въведеното число
            if (places > 0)
            {
                int division = (int)Math.Pow(10, times - places);
                reversed = reversed / division;
            }

            //  Отпечатваме крайния резултат
            Console.WriteLine(reversed);

            //DecimalNumber number = new DecimalNumber(Console.ReadLine());
            //Console.WriteLine(number.NumberReversed());
            //This is when use Arrays!!!
        }
    }
}
