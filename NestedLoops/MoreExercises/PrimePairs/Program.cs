using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairBegining = int.Parse(Console.ReadLine());
            int secondPairBegining = int.Parse(Console.ReadLine());
            int firstPairDiff = int.Parse(Console.ReadLine());
            int secondPairDiff = int.Parse(Console.ReadLine());

            int firstPairFinish = firstPairBegining + firstPairDiff;
            int secondPairFinish = secondPairBegining + secondPairDiff;

            for (int firstPair = firstPairBegining; firstPair <= firstPairFinish; firstPair++)
            {
                for (int secondPair = secondPairBegining; secondPair <= secondPairFinish; secondPair++)
                {
                    bool isFirstPime = true;
                    bool isSecondPrime = true;

                    for (int i = 2; i < firstPair; i++)
                    {
                        if (firstPair % i == 0)
                        {
                            isFirstPime = false;
                            break;
                        }
                    }
                    for (int j = 2; j < secondPair; j++)
                    {
                        if (secondPair % j == 0)
                        {
                            isFirstPime = false;
                            break;
                        }
                    }

                    string toString = firstPair.ToString() + secondPair.ToString();
                    int currentNum = int.Parse(toString);
                 
                    if (isFirstPime && isSecondPrime)
                    {
                        Console.WriteLine(currentNum);
                    }
                    
                }
            }
        }
    }
}
