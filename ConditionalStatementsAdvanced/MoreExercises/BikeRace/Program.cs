using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trackType = Console.ReadLine();

            double money = 0.0;
            if (trackType == "trail")
            {
                double juniorsMoney = juniors * 5.50;
                double seniorsMoney = seniors * 7;
                money = juniorsMoney + seniorsMoney;
            }
            else if (trackType == "cross-country")
            {
                double juniorsMoney = juniors * 8;
                double seniorsMoney = seniors * 9.50;
                money = juniorsMoney + seniorsMoney;
                if (juniors + seniors >= 50)
                {
                    money = money - (money * 25 / 100);
                }
            }
            else if (trackType == "downhill")
            {
                double juniorsMoney = juniors * 12.25;
                double seniorsMoney = seniors * 13.75;
                money = juniorsMoney + seniorsMoney;
            }
            else if (trackType == "road")
            {
                double juniorsMoney = juniors * 20;
                double seniorsMoney = seniors * 21.5;
                money = juniorsMoney + seniorsMoney;
            }

            double moneyAfterExpenses = money - (money * 5 / 100);

            Console.WriteLine($"{moneyAfterExpenses:F2}");

        }
    }
}
