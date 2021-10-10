using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {

            double valid = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0;

            for (int i = 0; i <= valid; i++)
            {
                for (int j = 0; j <= valid; j++)
                {
                    for (int m = 0; m <= valid; m++)
                    {
                         sum = i + j + m;
                        if (sum == valid)
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
