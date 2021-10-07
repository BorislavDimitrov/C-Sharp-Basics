using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int stepSum = 0;
            int steps = 0;

            while (input != "Going home" && stepSum < 10000 )
            {
                steps = int.Parse(input);
                stepSum += steps;
                input = Console.ReadLine();
            }

            if (stepSum >= 10000)
            {
                int difference = stepSum - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }

            if (input == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                stepSum += stepsToHome;
                int difference = stepSum - 10000;

                if (difference > 0)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{difference} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference)} more steps to reach goal.");
                }

            }
        }
    }
}
