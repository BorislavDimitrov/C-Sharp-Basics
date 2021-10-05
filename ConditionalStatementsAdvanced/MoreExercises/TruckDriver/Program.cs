using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometersMonthly = double.Parse(Console.ReadLine());
            double priceForKm = 0.0;
            if (kilometersMonthly <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    priceForKm = 0.75;
                }
                else if (season == "Summer")
                {
                    priceForKm = 0.90;
                }
                else if (season == "Winter")
                {
                    priceForKm = 1.05;
                }
            }
            else if (kilometersMonthly > 5000 && kilometersMonthly <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    priceForKm = 0.95;
                }
                else if (season == "Summer")
                {
                    priceForKm = 1.10;
                }
                else if (season == "Winter")
                {
                    priceForKm = 1.25;
                }
            }
            else if (kilometersMonthly > 10000 && kilometersMonthly <= 20000)
            {
                priceForKm = 1.45;
            }

            double money = priceForKm * kilometersMonthly * 4;
            double profit = money - (money * 10 / 100);
            Console.WriteLine($"{profit:F2}");
        }
    }
}
