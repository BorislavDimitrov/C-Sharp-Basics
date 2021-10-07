using System;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int classCount = 1;
            double yearlyGrade;
            int failGrade = 0;
            double averageGrade = 0.0;
            while (classCount <= 12)
            {

                yearlyGrade = double.Parse(Console.ReadLine());

                if (yearlyGrade < 4.00)
                {
                    failGrade += 1;
                }

                if (failGrade == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {classCount - 1} grade");

                    break;
                }

                averageGrade += yearlyGrade / 12;
                classCount++;

            }
            if (classCount >= 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
