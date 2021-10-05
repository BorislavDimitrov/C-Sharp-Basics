using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double rent = 0.0;

            switch (season)
            {
                case "Spring":
                    rent = 3000;
                break;

                case "Summer":
                case "Autumn":
                    rent = 4200;
                    break;

                case "Winter":
                    rent = 2600;
                    break;

                default:
                    break;
            }
            
           
            if (fishermen <= 6)
            {
                rent -= rent * 10 / 100;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                rent -= rent * 15 / 100;
            }
            else if (fishermen >= 12)
            {
                rent -= rent * 25 / 100;
            }

            if (fishermen % 2 == 0 && (season != "Autumn"))
            {
                rent -= rent * 5 / 100;
            }

            double difference = budget - rent;

            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {difference:F2} leva left.");
            }
            else if(budget < rent)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):F2} leva.");
            }
        }
    }
}
