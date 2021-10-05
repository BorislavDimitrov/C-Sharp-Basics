using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decorationExpenses = budget * 10 / 100;
            double clothesExpenses = clothesPrice * extras;

            if (extras > 150)
            {
                clothesExpenses = clothesExpenses - (clothesExpenses * 10 / 100);
            }

            double totalExpenses = decorationExpenses + clothesExpenses;

            if (totalExpenses > budget)
            {
                double moneyNeeded = totalExpenses - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }
            else 
            {
                double moneyLeft = budget - totalExpenses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }

        }
    }
}
