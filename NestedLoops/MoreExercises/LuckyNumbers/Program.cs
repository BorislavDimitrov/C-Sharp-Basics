using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int p = 1; p <= 9; p++)
                        {
                            if (i < 10 && j < 10 && k < 10 && p < 10)
                            {
                                if ((i + j == k + p) && (n % (i + j) == 0))
                                {
                                    Console.Write($"{i}{j}{k}{p} ");
                                }
                                
                            }
                           
                        }
                    }
                }
            }
        }
    }
}
