using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargoNum = int.Parse(Console.ReadLine());
            int tons;
            int pricePerTon = 0;
            string machine;
            double totalSum = 0;

            double minibusSum = 0;
            double truckSum = 0;
            double trainSum = 0;

            int minibusCount = 0;
            int truckCount = 0;
            int trainCount = 0;
            int tonsCount = 0;

            for (int i = 1; i <= cargoNum; i++)
            {
                tons = int.Parse(Console.ReadLine());
                tonsCount += tons;
                if (tons <= 3)
                {
                    pricePerTon = 200;
                    minibusSum += pricePerTon * tons;
                    
                    machine = "minibus";
                    minibusCount += tons;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    pricePerTon = 175;
                    truckSum += pricePerTon * tons;
                    machine = "truck";
                    truckCount += tons;
                }
                else if (tons >= 12)
                {
                    pricePerTon = 120;
                    trainSum += pricePerTon * tons;
                    machine = "train";
                    trainCount += tons;
                }
            }
            
            totalSum = minibusSum + truckSum + trainSum;
            double average = totalSum / tonsCount;

            double minibusPercent = minibusCount * 1.00 / tonsCount * 100;
            double truckPercent = truckCount * 1.00 / tonsCount * 100;
            double trainPercent = trainCount * 1.00 / tonsCount * 100;

            Console.WriteLine($"{average:F2}");
            Console.WriteLine($"{minibusPercent:F2}%");
            Console.WriteLine($"{truckPercent:F2}%");
            Console.WriteLine($"{trainPercent:F2}%");


        }
    }
}
