using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0; // 4etno
            int currentYears = 18;
            double totalSum = 0;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0 )
                {
                    evenSum += 12000;
                }
                else
                {
                    oddSum += 12000 + 50 * currentYears;
                }
                currentYears++;
            }

            totalSum = oddSum + evenSum;
            double difference = heritage - totalSum;
            if (heritage >= totalSum)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {difference:F2} dollars left.");
            }
            else if (heritage < totalSum)
            {
                Console.WriteLine($"He will need {Math.Abs(difference):F2} dollars to survive.");
            }
        }
    }
}
