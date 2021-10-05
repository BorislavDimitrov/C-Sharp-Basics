using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesNum = int.Parse(Console.ReadLine());
            int talkingDollsNum = int.Parse(Console.ReadLine());
            int bearsNum = int.Parse(Console.ReadLine());
            int minionsNum = int.Parse(Console.ReadLine());
            int trucksNum = int.Parse(Console.ReadLine());

            double puzzlePrice = puzzlesNum * 2.60;
            double talkingDollPrice = talkingDollsNum * 3;
            double bearsPrice = bearsNum * 4.10;
            double minionsPrice = minionsNum * 8.20;
            double truckPrice = trucksNum * 2;

            double toysPrice = puzzlePrice + talkingDollPrice + bearsPrice + minionsPrice + truckPrice;

            int toysNum = puzzlesNum + talkingDollsNum + bearsNum + minionsNum + trucksNum;

            double percentageDiscount = 0.25;
            

            if (toysNum >= 50)
            {
                toysPrice = toysPrice - (toysPrice * percentageDiscount);
            }
            double sum = toysPrice - (toysPrice * 10 / 100);
            
            if (sum >= tripPrice)
            {
                double moneyLeft = sum - tripPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double notEnoughMoney = tripPrice - sum;
                Console.WriteLine($"Not enough money! {notEnoughMoney:f2} lv needed.");
            }
        }

    }
}
