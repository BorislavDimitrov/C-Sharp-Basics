using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string flowerType = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            
            double price = 0.0;
            if (flowerType == "Roses" )
            {
                price = 5;
            }
            else if (flowerType == "Dahlias")
            {
                price = 3.80;
            }
            else if (flowerType == "Tulips")
            {
                price = 2.80;
            }
            else if (flowerType == "Narcissus")
            {
                price = 3;
            }
            else if (flowerType == "Gladiolus")
            {
                price = 2.50;
            }

            double sum = number * price;
            
            if (number > 80 && flowerType == "Roses")
            {
                sum -= sum * 10 / 100;
            }
            else if (number > 90 && flowerType == "Dahlias")
            {
                sum -= sum * 15 / 100;
            }
            else if (number > 80 && flowerType == "Tulips")
            {
                sum -= sum * 15 / 100;
            }
            else if (number < 120 && flowerType == "Narcissus")
            {
                sum += sum * 15 / 100;
            }
            else if (number < 80 && flowerType == "Gladiolus")
            {
                sum += sum * 20 / 100;
            }
            double difference = budget - sum;

            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flowerType} and {difference:F2} leva left.");
            }
            else if (budget < sum)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(difference):F2} leva more.");
            }
        }
    }
}
