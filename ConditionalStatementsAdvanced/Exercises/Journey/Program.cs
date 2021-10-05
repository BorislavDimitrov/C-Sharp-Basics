using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double expenses = 0.0;
            string destination = "";
            string placeToSleep = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    placeToSleep = "Camp";
                    expenses = budget * 30 / 100;
                }
                else if (season == "winter")
                {
                    placeToSleep = "Hotel";
                    expenses = budget * 70 / 100;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    placeToSleep = "Camp";
                    expenses = budget * 40 / 100;
                }
                else if (season == "winter")
                {
                    placeToSleep = "Hotel";
                    expenses = budget * 80 / 100;
                }
                
            }
            else if (budget > 1000)
            {
                placeToSleep = "Hotel";
                destination = "Europe";
                expenses = budget * 90 / 100;
            }



            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToSleep} - {expenses:F2}");

        }
    }
}
