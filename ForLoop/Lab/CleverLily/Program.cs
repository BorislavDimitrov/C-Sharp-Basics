using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toyCount = 0;
            double sum = 0.0;
            double birthdayMoney = 10;

            for (int i = 1; i <= lilyAge; i++)
            {
                
                if (i % 2 == 0)
                {
                    sum += birthdayMoney - 1;
                    birthdayMoney += 10;
                }
                else
                {
                    toyCount += 1;
                }
            }

            double toySum = toyCount * toyPrice;

            sum += toySum;

            double difference = Math.Abs(sum - laundryPrice);
            if (sum >= laundryPrice)
            {
                Console.WriteLine($"Yes! {difference:F2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:F2}");
            }
        }
    }
}
