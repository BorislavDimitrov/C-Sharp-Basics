using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isItHolyday = Console.ReadLine();

            double sum = 0.0;
            double chrysanthemusPrice = 0.0;
            double rosePrice = 0.0;
            double tulipPrice = 0.0;

            if (season == "Spring" || season == "Summer")
            {
                 chrysanthemusPrice = 2.00;
                 rosePrice = 4.10;
                 tulipPrice = 2.50;
                if (isItHolyday == "Y")
                {
                    chrysanthemusPrice = chrysanthemusPrice + (chrysanthemusPrice * 15 / 100);
                    rosePrice = rosePrice + (rosePrice * 15 / 100);
                    tulipPrice = tulipPrice + (tulipPrice * 15 / 100);
                }

            }
            else if (season == "Winter" || season == "Autumn")
            {
                 chrysanthemusPrice = 3.75;
                 rosePrice = 4.50;
                 tulipPrice = 4.15;
                if (isItHolyday == "Y")
                {
                    chrysanthemusPrice = chrysanthemusPrice + (chrysanthemusPrice * 15 / 100);
                    rosePrice = rosePrice + (rosePrice * 15 / 100);
                    tulipPrice = tulipPrice + (tulipPrice * 15 / 100);
                }
            }
            sum = chrysanthemusPrice * chrysanthemums + rosePrice * roses + tulipPrice * tulips;

            if (chrysanthemums + roses + tulips > 20) 
            {
                 sum = sum - (sum * 20 / 100);
            }

             if (roses >= 10 && season == "Winter")
            {
                sum = sum - (sum * 10 / 100);
            }

             if (tulips > 7 && season == "Spring")
            {
                sum = sum - (sum * 5 / 100);
            }
            double finalSum = sum + 2;

            Console.WriteLine($"{finalSum:F2}");
        }
    }
} 
