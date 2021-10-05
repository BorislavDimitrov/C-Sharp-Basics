using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double sum = 0.0;
            

            switch (projectType)
            {
                case "Premiere":
                    sum = rows *  colums * 12;
                    break;
                case "Normal":
                    sum = rows *  colums * 7.50;
                    break;
                case "Discount":
                    sum = rows *  colums * 5;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
