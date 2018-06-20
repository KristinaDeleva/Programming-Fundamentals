using System;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits7(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool ContainsEvenDigit(int i)
        {
                int current = 0;
                bool hasEven = false;
                while (i != 0)
                {
                    current = i % 10;
                    if (current % 2 == 0)
                    {
                        hasEven = true;
                        return hasEven;
                    }
                    i /= 10;
                }
                return hasEven;
        }

        static bool SumOfDigits7(int i)
        {
            int sumDigit = 0;
            while (i != 0)
            {
                sumDigit += i % 10;
                i /= 10;
            }
            if (sumDigit % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsPalindrome(int i)
        {
            bool isPalindrome = false;
            int reversed = 0;
            int oldNum = i;
            int power = i.ToString().Length - 1;
            int loops = i.ToString().Length;
            for (int j = 0; j < loops; j++)
            {
                reversed += i % 10 * (int)Math.Pow(10, power);
                power--;
                i /= 10;
            }
            if (reversed == oldNum)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
            return isPalindrome;

            //int reversed = 0;
            //int oldNum = i;
            //while (i != 0)
            //{
            //    reversed *= 10;
            //    reversed += i % 10;
            //    i /= 10;
            //}
            //if (reversed == oldNum)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        }
    }

