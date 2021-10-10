using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (int i = begining; i <= finish; i++)
            {
                for (int j = begining; j <= finish; j++)
                {
                    for (int k = begining; k <= finish; k++)
                    {
                        for (int p = begining; p <= finish; p++)
                        {
                            if ((i % 2 != p % 2) && (i > p) && ((j + k) % 2 == 0))
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
