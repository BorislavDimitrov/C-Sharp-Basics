using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int sum = 0;
            int maxNum = int.MinValue;
            
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
                

            }
            int difference = Math.Abs((sum - maxNum) - maxNum);
            if (maxNum == (sum - maxNum))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
