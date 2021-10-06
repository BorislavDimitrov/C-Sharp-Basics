using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            string sector;
            int fansCounter = 0;
            int sectorACounter = 0;
            int sectorBCounter = 0;
            int sectorVCounter = 0;
            int sectorGCounter = 0;


            for (int i =1; i <= fans; i++) 
            {
                sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorACounter++;
                }
                else if (sector == "B")
                {
                    sectorBCounter++;
                }
                else if (sector == "V")
                {
                    sectorVCounter++;
                }
                else if (sector == "G")
                {
                    sectorGCounter++;
                }

                fansCounter++;
            }

            double sectorAPercent = sectorACounter * 1.00 / fans * 100;
            double sectorBPercent = sectorBCounter * 1.00 / fans * 100;
            double sectorVPercent = sectorVCounter * 1.00 / fans * 100;
            double sectorGPercent = sectorGCounter * 1.00 / fans * 100;
            double fansPercent = fans * 1.00 / stadiumCapacity * 100;

            Console.WriteLine($"{sectorAPercent:F2}%");
            Console.WriteLine($"{sectorBPercent:F2}%");
            Console.WriteLine($"{sectorVPercent:F2}%");
            Console.WriteLine($"{sectorGPercent:F2}%");
            Console.WriteLine($"{fansPercent:F2}%");
        }
    }
}
