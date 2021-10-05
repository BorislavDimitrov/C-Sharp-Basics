using System;

namespace fruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //цената на малините е на половина по - ниска от тази на ягодите;
            // цената на портокалите е с 40 % по - ниска от цената на малините;
            // цената на бананите е с 80 % по - ниска от цената на малините.
       

            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double raspberriesKg = double.Parse(Console.ReadLine());
            double strawberryKg = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberryPrice / 2;
            double orangesPrice = raspberriesPrice - (raspberriesPrice * 40 / 100);
            double bananaPrice = raspberriesPrice - raspberriesPrice * 80 / 100;

            double strawberrySum = strawberryPrice * strawberryKg;
            double bananaSum = bananaKg * bananaPrice;
            double orangeSum = orangeKg * orangesPrice;
            double raspberrySum = raspberriesPrice * raspberriesKg;

            double totalSum = strawberrySum + bananaSum + orangeSum + raspberrySum;

            Console.WriteLine(totalSum);








        }
    }
}
