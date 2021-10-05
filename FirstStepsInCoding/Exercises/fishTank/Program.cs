using System;

namespace fishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double fishTankVolume = lenght * widht * height;
            double totalLitters = fishTankVolume * 0.001;
            percentage = percentage / 100;
            double littersNeeded = totalLitters * (1 - percentage);

            Console.WriteLine(littersNeeded);



        }
    }
}
