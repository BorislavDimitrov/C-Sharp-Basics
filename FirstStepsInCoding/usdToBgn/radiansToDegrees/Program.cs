using System;

namespace radiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());

            double radius = radians * 180 / Math.PI;

            Console.WriteLine(Math.Round(radius));
        }
    }
}
