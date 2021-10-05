using System;

namespace MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (num >= 0)
            {
                double result = num * 2;
                Console.WriteLine($"Result: {result:F2}");
                num = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Negative number!");
        }
    }
}
