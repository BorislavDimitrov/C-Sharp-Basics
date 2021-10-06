using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum1 = num1 + num2;
            int diffCurrent = 0;
            
            for (int i = 1; i <= n - 1; i++)
            {
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                int sum2 = num1 + num2;

                if (sum1 != sum2)
                {
                    int difference = Math.Abs(sum1 - sum2);
                    if (difference > diffCurrent)
                    {
                        diffCurrent = difference;
                    }
                    sum1 = sum2;
                }

            }

            if (diffCurrent > 0)
            {
                Console.WriteLine($"No, maxdiff={diffCurrent}");
            }
            else
            {
                Console.WriteLine($"Yes, value={sum1}");
            }
        }
    }
}
