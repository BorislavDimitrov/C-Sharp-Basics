using System;

namespace petShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsNum = int.Parse(Console.ReadLine());
            int restAnimals = int.Parse(Console.ReadLine());

            double result = dogsNum * 2.5 + restAnimals * 4;
            Console.WriteLine($"{result} lv.");
        }
    }
}
