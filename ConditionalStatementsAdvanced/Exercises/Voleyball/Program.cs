using System;

namespace Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double timesPlayed = 0.0;

            timesPlayed = 48 - h;
            timesPlayed = timesPlayed * 3 / 4;
            double holidaysPlayed = p * 2.00 / 3;

            timesPlayed = timesPlayed + holidaysPlayed + h;
            

            
            

            if (yearType == "leap")
            {
                timesPlayed += timesPlayed * 15 / 100;
            }
            
            Console.WriteLine($"{Math.Floor(timesPlayed)}");
        }
    }
}

