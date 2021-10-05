using System;

namespace NumberFrom1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            while (num != 10)
            {
                num++;
                Console.WriteLine(num);
            }
        }
    }
}
