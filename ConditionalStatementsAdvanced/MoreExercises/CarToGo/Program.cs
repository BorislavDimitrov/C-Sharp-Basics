using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carClass;
            string carType;
            double carPrice = 0.0;

            if (budget > 500)
            {
                 carPrice = budget * 90 / 100;
                carType = "Jeep";
                carClass = "Luxury class";
                Console.WriteLine(carClass);
                Console.WriteLine($"{carType} - {carPrice:F2}");
            }
            else if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 35 / 100;
                    Console.WriteLine(carClass);
                    Console.WriteLine($"{carType} - {carPrice:F2}");
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 65 / 100;
                    Console.WriteLine(carClass);
                    Console.WriteLine($"{carType} - {carPrice:F2}");
                }             
            }
            else if (budget > 100 && budget <= 500 )
            {
                carClass = "Compact class";
                
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carPrice = budget * 45 / 100;
                    Console.WriteLine(carClass);
                    Console.WriteLine($"{carType} - {carPrice:F2}");
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carPrice = budget * 80 / 100;
                    Console.WriteLine(carClass);
                    Console.WriteLine($"{carType} - {carPrice:F2}");
                }
                
            }

        }
    }
}
