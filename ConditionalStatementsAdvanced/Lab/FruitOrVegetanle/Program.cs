using System;

namespace FruitOrVegetanle
{
    class Program
    {
        static void Main(string[] args)
        {
            string plant = Console.ReadLine();

            switch (plant)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "carrot":
                case "pepper":
                case "cucumber":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
