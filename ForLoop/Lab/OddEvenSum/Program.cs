using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum1 = 0.0;
            double sum2 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double m = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 += m;
                }
                else
                {
                    sum2 += m;
                }
            }
            double difference = Math.Abs(sum1 - sum2);
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
