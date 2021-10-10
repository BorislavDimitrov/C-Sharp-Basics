using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNum = int.Parse(Console.ReadLine());
            int hoursNum = int.Parse(Console.ReadLine());

             double totalSum = 0;

            for (int days = 1; days <= daysNum; days++)
            {
                double currentDaySum = 0;
                for (int hours = 1; hours <= hoursNum; hours++)
                {
                    double currentSum = 0;
                    double tax = 1; ;
                    if (days % 2 == 0 && hours % 2 != 0)
                    {
                        tax = 2.50;
                    }
                    else if (days % 2 != 0 && hours % 2 == 0)
                    {
                        tax = 1.25;
                    }
                    currentSum += tax;
                    currentDaySum += currentSum;
                    totalSum += currentSum;
                    
                }
                
                Console.WriteLine($"Day: {days} - {currentDaySum:F2} leva");
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
