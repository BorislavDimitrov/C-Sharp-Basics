using System;

namespace sumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double m;
            for (int i = 1; i <= n; i++)
            {
                m = double.Parse(Console.ReadLine());

                sum += m;
            }
            Console.WriteLine(sum);
        }
    }
}
