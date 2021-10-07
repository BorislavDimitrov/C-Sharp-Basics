using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m ;
            int sum = 0;
            while (sum < n)
            {
                m = int.Parse(Console.ReadLine());
                sum = sum + m;
                

            }
            Console.WriteLine(sum);
        }
    }
}
