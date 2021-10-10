using System;

namespace SecretDoorsLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundredsBorder = int.Parse(Console.ReadLine());
            int tensBorder = int.Parse(Console.ReadLine());
            int onesBorder = int.Parse(Console.ReadLine());

           

            for (int hundreds = 1; hundreds <= hundredsBorder; hundreds++)
            {
                for (int tens = 1; tens <= tensBorder; tens++)
                {
                    for (int ones = 1; ones <= onesBorder; ones++)
                    {
                        bool isBetween = false;
                        bool isEven = false;
                        bool isPrime = true;
                        if (tens >= 2 && tens <= 7)
                        {
                            isBetween = true;
                        }

                        if (hundreds % 2 == 0 && ones % 2 == 0)
                        {
                            isEven = true;
                        }

                        for (int i = 2; i < tens; i++)
                        {
                            if (tens % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime && isEven && isBetween)
                        {
                            Console.WriteLine($"{hundreds} {tens} {ones}");
                        }
                    }
                }
            }
        }
    }
}
