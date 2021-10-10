using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalStop = int.Parse(Console.ReadLine());
            int sum = 0;
            int num1 = 0;
            int num2 = 0;
            int magicNum = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            bool flag = true;

            for (int i = intervalStart; i <= intervalStop; i++)
            {
                num1 = i;
                for (int j = intervalStart; j <= intervalStop ; j++)
                {
                    num2 = j;
                    sum = i + j;
                    combinationsCounter++;
                    if (sum == magicNum)
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"Combination N:{combinationsCounter} ({num1} + {num2} = {magicNum})");
            }
            else if (flag)
            {
                Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicNum}");
            }

        }
    }
}
