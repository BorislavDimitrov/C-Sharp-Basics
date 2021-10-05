using System;

namespace TimePlus15Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            mins += 15;

            if (mins >= 60)
            {
                hours = hours + mins / 60;
            }
            mins = mins % 60;
            if (hours >= 24)
            {
                hours = hours % 24;
            }
            
            if (mins < 10 )
            {
                Console.WriteLine(hours + ":0" + mins);
            }
            else
            {
                Console.WriteLine(hours + ":" + mins);
            }
        }
    }
}
