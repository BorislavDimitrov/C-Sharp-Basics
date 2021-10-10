using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevNum = int.Parse(Console.ReadLine());
            int twoLevaNum = int.Parse(Console.ReadLine());
            int fiveLevaNum = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int oneLev = 1;
            int twoLeva = 2;
            int fiveLeva = 5;

            for (int one = 0; one <= oneLevNum; one++)
            {
                for (int two = 0; two <= twoLevaNum; two++)
                {
                    for (int five = 0; five <= fiveLevaNum; five++)
                    {
                        int currentSum = 0;
                        currentSum = one * oneLev + two * twoLeva + five * fiveLeva;

                        if (currentSum == sum)
                        {
                            Console.WriteLine($"{one} * 1 lv. + {two} * 2 lv. + {five} * 5 lv. = {sum} lv.");
                        }
                        currentSum = 0;
                    }
                }
            }
        }
    }
}
