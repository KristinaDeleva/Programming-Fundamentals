using System;

namespace Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            bool canShake = true;

            while (canShake)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);

                if (firstIndex>-1&&lastIndex>-1&&pattern.Length>0)
                {
                    firstIndex = input.IndexOf(pattern);
                    input = input.Remove(firstIndex, pattern.Length);
                    lastIndex = input.LastIndexOf(pattern);
                    input = input.Remove(lastIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");

                    if (pattern.Length>0)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    canShake = false;
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
