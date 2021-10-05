using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            w = w * 100;
            h = h * 100;

            h = h - 100;
            double desks = Math.Floor(h / 70);
            double rows = Math.Floor(w / 120);
            Console.WriteLine( desks);
            Console.WriteLine(rows);

            double spots = desks * rows - 3;
            Console.WriteLine($"{spots}");

             
        }
    }
}
