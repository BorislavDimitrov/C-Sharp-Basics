using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.x – височината на къщата – реално число в интервала[2...100]
            //2.y – дължината на страничната стена – реално число в интервала[2...100]
            //3.h – височината на триъгълната стена на прокрива – реално число в интервала[2...100]
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wallsArea = 2 *(x * y) + 2*(x * x) - (1.2 * 2) - 2*(1.5 * 1.5);
            double roofArea = 2 * (x * y) + 2 * (x * h / 2);

            double greenPainting = wallsArea / 3.4;
            double redPainting = roofArea / 4.3;

             Console.WriteLine($"{greenPainting:F2}");
            Console.WriteLine($"{redPainting:F2}");

        }
    }
}
