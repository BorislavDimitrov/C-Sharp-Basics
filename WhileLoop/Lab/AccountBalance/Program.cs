using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            double sum = 0.0;

            while (text != "NoMoreMoney")
            {
                 double deposit = double.Parse(text);

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");

                    break;
                }
                 
                    sum += deposit;
                    Console.WriteLine($"Increase: {deposit:F2}");
                    text = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
