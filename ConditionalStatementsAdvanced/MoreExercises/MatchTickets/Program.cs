using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        { 
            double budget = double.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double transportExpenses = 0.0;

            if (people >=1 && people <=4 )
            {
                transportExpenses = budget * 75 / 100;
            }
            else if (people >= 5 && people <= 9)
            {
                transportExpenses = budget * 60 / 100;
            }
            else if (people >= 10 && people <= 24)
            {
                transportExpenses = budget * 50 / 100;
            }
            else if (people >= 25 && people <= 49)
            {
                transportExpenses = budget * 40 / 100;
            }
            else if (people >= 50)
            {
                transportExpenses = budget * 25 / 100;
            }

            double ticketPrice = 0.0;

            if (ticketCategory == "Normal")
            {
                ticketPrice = 249.99;
            }
            else if (ticketCategory == "VIP")
            {
                ticketPrice = 499.99;
            }

            double ticketMoney =  ticketPrice * people;
            double sum =  ticketMoney + transportExpenses;
            
            if (budget >= sum)
            {
                double moneyLeft = budget - sum;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeed = Math.Abs(budget - sum);
                Console.WriteLine($"Not enough money! You need {moneyNeed:F2} leva.");
            }

        }
    }
}
