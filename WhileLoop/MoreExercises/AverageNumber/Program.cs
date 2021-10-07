using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                m = int.Parse(Console.ReadLine());
                sum += m;    
            }

            double average = sum / (n * 1.00);
            
            Console.WriteLine($"{average:F2}");
        }
    }
}
