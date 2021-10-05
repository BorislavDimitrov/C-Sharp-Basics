using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string shoes;
            string outfit;

            switch (time)
            {
                case "Morning":
                    if (10 <= degrees && degrees <= 18)
                    {
                        shoes = "Sneakers";
                        outfit = "Sweatshirt";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (18 < degrees && degrees <= 24)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degrees >= 25)
                    {
                        shoes = "Sandals";
                        outfit = "T-Shirt";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                case "Afternoon":
                    if (10 <= degrees && degrees <= 18)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (18 < degrees && degrees <= 24)
                    {
                        shoes = "Sandals";
                        outfit = "T-Shirt";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degrees >= 25)
                    {
                        shoes = "Barefoot";
                        outfit = "Swim Suit";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                case "Evening":
                    if (10 <= degrees && degrees <= 18)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (18 < degrees && degrees <= 24)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degrees >= 25)
                    {
                        shoes = "Moccasins";
                        outfit = "Shirt";
                        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
