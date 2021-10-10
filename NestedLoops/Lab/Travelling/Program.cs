using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double budget= 0;
            double sum;
            double currentSum = 0;
            
            while (input != "End")
            {
                if (input != "End")
                {
                    budget = double.Parse(Console.ReadLine());
                }

                while (budget > currentSum )
                {
                    sum = double.Parse(Console.ReadLine());
                    currentSum += sum;
                    if (currentSum >= budget)
                    {
                        Console.WriteLine($"Going to {input}!");
                        currentSum = 0;
                        break;
                    }
                }

                input = Console.ReadLine();               
            }
        }
    }
}
