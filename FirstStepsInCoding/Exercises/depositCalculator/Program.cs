using System;

namespace depositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double yearlyPercentage = double.Parse(Console.ReadLine());
            yearlyPercentage = yearlyPercentage / 100;

            double sum = deposit + months * ((deposit * yearlyPercentage) / 12);

            Console.WriteLine(sum);
        }
    }
}
