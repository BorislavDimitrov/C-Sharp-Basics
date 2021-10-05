using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();
            double sum = 0.0;

            switch (mathOperator)
            {
                case "+":
                    sum = num1 + num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - odd");
                    }
                    break;
                case "-":
                    sum = num1 - num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} - {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} - {num2} = {sum} - odd");
                    }
                    break;
                case "*":
                    sum = num1 * num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} * {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} * {num2} = {sum} - odd");
                    }
                    break;
                case "/":
                    sum = num1 / num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} / {num2} = {sum:F2}");
                    }
                    
                    break;
                case "%":
                    sum = num1 % num2;
                    if ( num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} % {num2} = {sum}");
                    }
                    break;
                default:
                    break;
            }

            
        }
    }
}
