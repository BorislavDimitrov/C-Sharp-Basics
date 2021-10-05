using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());

            double ivanTime = distance * speed;
            double n = Math.Floor(distance / 15);
            ivanTime = ivanTime + n * 12.5;
            

            double difference = ivanTime - record;
           

            if (ivanTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:F2} seconds.");
            }
            else if (ivanTime >= record)
            {
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }

        }
    }
}
