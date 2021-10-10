using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            bool isMagic = false;
           
            for (int i = begining; i <= finish; i++)
            {
                for (int j = begining; j <= finish; j++)
                {
                    int currentSum = 0;
                    currentSum = i + j;
                    counter++;
                    if (currentSum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        isMagic = true;
                        break;
                    }
                }
                if (isMagic)
                {
                    break;
                }
            }
            if (!isMagic)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
