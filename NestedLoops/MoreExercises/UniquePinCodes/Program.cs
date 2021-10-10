using System;

namespace UniquePinCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumBorder = int.Parse(Console.ReadLine());
            int secondNumBorder = int.Parse(Console.ReadLine());
            int thirdNumBorder = int.Parse(Console.ReadLine());

            
            
            for (int i = 1; i <= firstNumBorder; i++)
            {
                for (int j = 1; j <= secondNumBorder; j++)
                {
                    for (int k = 1; k <= thirdNumBorder; k++)
                    {                       
                        bool isPrime = true;

                        for (int p = 2; p < j ; p++)
                            {
                                
                                if (j % p == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }
                       
                        if (isPrime  && i % 2 == 0 && k % 2 == 0 && j >= 2 && j <= 7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
