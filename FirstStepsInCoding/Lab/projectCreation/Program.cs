using System;

namespace projectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsNum = int.Parse(Console.ReadLine());

            int hoursNeeded = projectsNum * 3;

            Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {projectsNum} project/s.");
        }
    }
}
