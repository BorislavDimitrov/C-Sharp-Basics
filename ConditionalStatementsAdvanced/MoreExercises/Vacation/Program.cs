using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string stayIn;
            string location;
            double price = 0.0;
            

            if (budget <= 1000 )
            {
                stayIn = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 65 / 100;
                    Console.WriteLine($"{location} - {stayIn} - {price:F2}");
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 45 / 100;
                    Console.WriteLine($"{location} - {stayIn} - {price:F2}");
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                stayIn = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 80 / 100;
                    Console.WriteLine($"{location} - {stayIn} - {price:F2}");
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 60 / 100;
                    Console.WriteLine($"{location} - {stayIn} - {price:F2}");
                }
            }
            else if (budget > 3000)
            {
                price = budget * 90 / 100;
                stayIn = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    Console.WriteLine($"{location} - {stayIn} - {price:F2}");
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    Console.WriteLine($"{location} - {stayIn} - {price:F2}");

                }
            }
            

        }
    }
}
