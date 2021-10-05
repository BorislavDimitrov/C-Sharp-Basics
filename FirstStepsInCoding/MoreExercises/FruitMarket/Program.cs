using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Цена за килограм зеленчуци – реално число[0.00… 1000.00]
            //•	Втори ред – Цена за килограм плодове – реално число[0.00… 1000.00]
            //•	Трети ред – Общо килограми на зеленчуците – цяло число[0… 1000]
            //•	Четвърти ред – Общо килограми на плодовете – цяло число[0… 1000]
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesKg = int.Parse(Console.ReadLine());
            int fruitKg = int.Parse(Console.ReadLine());

            double vegetableSum = vegetablesPrice * vegetablesKg;
            double fruitSum = fruitsPrice * fruitKg;

            double totalSum = (vegetableSum + fruitSum) / 1.94;

            Console.WriteLine($"{totalSum:F2}");


        }
    }
}
