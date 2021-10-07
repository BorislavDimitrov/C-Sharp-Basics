using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumNeeded = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 1;
            double price = 0;
            double payInCash = 0;
            int payInCashCounter = 0;
            double payWithCard = 0;
            int payWithCardCounter = 0;
            double totalSum = 0;


            while (input != "End")
            {
                price = int.Parse(input);
                if (counter % 2 == 0 )
                {
                    if (price < 10)
                    {
                        price = 0;
                        Console.WriteLine("Error in transaction!");
                        
                    }
                    else 
                    {
                        payWithCard += price;
                        Console.WriteLine("Product sold!");
                        payWithCardCounter++;
                    }
                }
                else
                {
                    if (price > 100)
                    {
                        price = 0;
                        Console.WriteLine("Error in transaction!");
                        
                    }
                    else
                    {
                        payInCash += price;
                        Console.WriteLine("Product sold!");
                        payInCashCounter++;
                    }
                }
                totalSum = payInCash + payWithCard;
                counter++;

                if (totalSum >= sumNeeded)
                {
                    double averagePayInCash = payInCash / payInCashCounter;
                    Console.WriteLine($"Average CS: {averagePayInCash:F2}");
                    double averagePayWithCard = payWithCard / payInCashCounter;
                    Console.WriteLine($"Average CC: {averagePayWithCard:F2}");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }

        }
    }
}
