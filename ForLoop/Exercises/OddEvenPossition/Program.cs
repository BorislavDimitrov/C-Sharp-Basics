using System;

namespace OddEvenPossition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m;

            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                m = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += m;

                    if (m > evenMax)
                    {
                        evenMax = m;
                    }

                    if (m < evenMin)
                    {
                        evenMin = m;
                    }
                }
                else
                {
                    oddSum += m;

                    if (m > oddMax)
                    {
                        oddMax = m;
                    }

                    if (m < oddMin)
                    {
                        oddMin = m;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:F2},");

            if (oddMin == double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,"); 
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }

            if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
       
            Console.WriteLine($"EvenSum={evenSum:F2},");

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,"); 
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }

            if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        
        }
    }
}
