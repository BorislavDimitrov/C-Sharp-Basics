using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double area = radius * radius * Math.PI;
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
