using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = int.Parse(Console.ReadLine());
            int num;
            double result = 0;

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            
         

            for (int i = 1; i <= turns; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    
                    result += num* 1.00 * 20 / 100;
                    counter1++;
                }
                else if (num >= 10 && num <= 19)
                {
                    
                    result += num * 1.00 * 30 / 100;
                    counter2++;
                }
                else if (num >= 20 && num <= 29)
                {
                    
                    result += num * 1.00 * 40 / 100;
                    counter3++;
                }
                else if (num >= 30 && num <= 39)
                {
                    
                    result += 50;
                    counter4++;
                }
                else if (num >= 40 && num <= 50)
                {
                    
                    result += 100;
                    counter5++;
                }
                else if (num > 50 || num < 0)
                {
                    result /= 2;
                    counter6++;
                }
            }
           
            Console.WriteLine($"{result:F2}");


            double zeroToNine = counter1 * 1.00 / turns * 100;
            Console.WriteLine($"From 0 to 9: {zeroToNine:F2}%");

            double tenToNineteen = counter2 * 1.00 / turns * 100;
            Console.WriteLine($"From 10 to 19: {tenToNineteen:F2}%");

            double twentyToTwentynine = counter3 * 1.00 / turns * 100;
            Console.WriteLine($"From 20 to 29: {twentyToTwentynine:F2}%");

            double thirtyToThirtynine = counter4 * 1.00 / turns * 100;
            Console.WriteLine($"From 30 to 39: {thirtyToThirtynine:F2}%");

            double fortyToFifty = counter5 * 1.00 / turns * 100;
            Console.WriteLine($"From 40 to 50: {fortyToFifty:F2}%");

            double invalidNumbers = counter6 * 1.00 / turns * 100;
            Console.WriteLine($"Invalid numbers: {invalidNumbers:F2}%");

        

        }
    }
}
