using System;

namespace NumberSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            int m;

            for (int i = 1; i <= n; i++)
            {
                m = int.Parse(Console.ReadLine());

                if (m > maxNum)
                {
                    maxNum = m;
                }
                if (m < minNum)
                {
                    minNum = m;
                }
            }
                Console.WriteLine($"Max number: {maxNum}");
                            Console.WriteLine($"Min number: {minNum}");
        }
        
    }
}
