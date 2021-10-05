using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            if (num > num2)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
