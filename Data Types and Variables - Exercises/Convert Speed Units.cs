using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float time = seconds + minutes * 60 + hours * 3600;

            float mPerS = distance / time;
            float kmPerH = (distance / 1000)/(time / 3600);
            float mpPerH = (distance / 1609) / (time / 3600);

            Console.WriteLine($"{mPerS:0.######}");
            Console.WriteLine($"{kmPerH:0.######}");
            Console.WriteLine($"{mpPerH:0.######}");
        }
    }
}
