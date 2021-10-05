using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();
            int nights = days - 1;
            double sum = 0.0;
            switch (roomType)
            {
                case "room for one person":
                    if (days < 10)
                    {
                        sum = nights * 18.00;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        sum = nights * 18.00;
                    }
                    else if (days > 15)
                    {
                        sum = nights * 18.00;
                    }
                    break;
                case "apartment":
                    if (days < 10)
                    {
                        sum = nights * 25.00;
                        sum = sum - (sum * 30 / 100);
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        sum = nights * 25.00;
                        sum = sum - (sum * 35 / 100);
                    }
                    else if (days > 15)
                    {
                        sum = nights * 25.00;
                        sum = sum - (sum * 50 / 100);
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        sum = nights * 35.00;
                        sum = sum - (sum * 10 / 100);
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        sum = nights * 35.00;
                        sum = sum - (sum * 15 / 100);
                    }
                    else if (days > 15)
                    {
                        sum = nights * 35.00;
                        sum = sum - (sum * 20 / 100);
                    }
                    break;
                default:
                    break;
            }
            double finalSum = 0.0;
            if (rate == "positive")
            {
                finalSum = sum + (sum * 25 / 100);
            }
            else if (rate == "negative")
            {
                finalSum = sum - (sum * 10 / 100);
            }

            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
