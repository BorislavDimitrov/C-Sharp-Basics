using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine()) * 100;
            int coinsCount = 0;

            while (money > 0)
            {
                if (money > 200)
                {
                    money -= 200;
                    coinsCount++;
                }
                else if (money >= 100)
                {
                    money -= 100;
                    coinsCount++;
                }
                else if (money >= 50)
                {
                    money -= 50;
                    coinsCount++;
                }
                else if (money >= 20)
                {
                    money -= 20;
                    coinsCount++;
                }
                else if (money >= 10)
                {
                    money -= 10;
                    coinsCount++;
                }
                else if (money >= 5)
                {
                    money -= 5;
                    coinsCount++;
                }
                else if (money >= 2)
                {
                    money -= 2;
                    coinsCount++;
                }
                else if (money >= 1)
                {
                    money -= 1;
                    coinsCount++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(coinsCount);
        }
    }
}
