using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double sum = 0.0;
            switch (city)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        sum = amount * 0.50;
                    }
                    else if (product == "water")
                    {
                        sum = amount * 0.80;
                    }
                    else if (product == "beer")
                    {
                        sum = amount * 1.20;
                    }
                    else if (product == "sweets")
                    {
                        sum = amount * 1.45;
                    }
                    else if (product == "peanuts")
                    {
                        sum = amount * 1.60;
                    }
                        break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        sum = amount * 0.40;
                    }
                    else if (product == "water")
                    {
                        sum = amount * 0.70;
                    }
                    else if (product == "beer")
                    {
                        sum = amount * 1.15;
                    }
                    else if (product == "sweets")
                    {
                        sum = amount * 1.30;
                    }
                    else if (product == "peanuts")
                    {
                        sum = amount * 1.50;
                    }
                    break;
                case "Varna":
                    if (product == "coffee")
                    {
                        sum = amount * 0.45;
                    }
                    else if (product == "water")
                    {
                        sum = amount * 0.70;
                    }
                    else if (product == "beer")
                    {
                        sum = amount * 1.10;
                    }
                    else if (product == "sweets")
                    {
                        sum = amount * 1.35;
                    }
                    else if (product == "peanuts")
                    {
                        sum = amount * 1.55;
                    }
                    break;
                default:
                   
                    break;
                   
            }
                Console.WriteLine(sum);
    }
        } 
}
