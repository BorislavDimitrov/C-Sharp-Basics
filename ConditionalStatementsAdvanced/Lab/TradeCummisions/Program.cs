using System;

namespace TradeCummisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double amountSales = double.Parse(Console.ReadLine());
            double bonus;
            switch (city)
            {
                case "Sofia":
                    if (amountSales >= 0 && amountSales <= 500 )
                    {
                        bonus = amountSales * 5 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales > 500 && amountSales <= 1000)
                    {
                        bonus = amountSales * 7 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales >1000 && amountSales <= 10000)
                    {
                        bonus = amountSales * 8 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales > 10000)
                    {
                        bonus = amountSales * 12 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (amountSales >= 0 && amountSales <= 500)
                    {
                        bonus = amountSales * 4.5 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales > 500 && amountSales <= 1000)
                    {
                        bonus = amountSales * 7.5 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales > 1000 && amountSales <= 10000)
                    {
                        bonus = amountSales * 10 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales > 10000)
                    {
                        bonus = amountSales * 13 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (amountSales >= 0 && amountSales <= 500)
                    {
                        bonus = amountSales * 5.5 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales > 500 && amountSales <= 1000)
                    {
                        bonus = amountSales * 8 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales > 1000 && amountSales <= 10000)
                    {
                        bonus = amountSales * 12 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales > 10000)
                    {
                        bonus = amountSales * 14.5 / 100;
                        Console.WriteLine($"{bonus:F2}");
                    }
                    else if (amountSales < 0)
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
