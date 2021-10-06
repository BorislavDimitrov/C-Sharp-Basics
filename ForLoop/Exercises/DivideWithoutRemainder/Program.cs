using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;


            for (int i = 1; i <= n; i++)
            {

                m = int.Parse(Console.ReadLine());

                if (m % 2 == 0)
                {
                    p1 += 1;
                }

                if (m % 3 == 0)
                {
                    p2 += 1;
                }

                if (m % 4 == 0)
                {
                    p3 += 1;
                }
            }
            p1 = p1 /n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
