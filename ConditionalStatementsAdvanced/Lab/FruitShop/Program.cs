using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double sum = 0.0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        sum = amount * 2.50;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "apple")
                    {
                        sum = amount * 1.20;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "orange")
                    {
                        sum = amount * 0.85;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        sum = amount * 1.45;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        sum = amount * 2.70;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        sum = amount * 5.50;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "grapes")
                    {
                        sum = amount * 3.85;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                    break;
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        sum = amount * 2.70;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "apple")
                    {
                        sum = amount * 1.25;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "orange")
                    {
                        sum = amount * 0.90;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        sum = amount * 1.60;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        sum = amount * 3.00;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        sum = amount * 5.60;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else if (fruit == "grapes")
                    {
                        sum = amount * 4.20;
                        Console.WriteLine($"{sum:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            
        }
    }
}
