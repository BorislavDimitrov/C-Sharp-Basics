using System;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judgesNum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double averageGradeSum = 0.0;
            double averageGrade = 0;
            int presentationsCounter = 0;

            while (input != "Finish")
            {
                string presentationName = input;
                presentationsCounter++;
                double grades;
                double currentGrades = 0;
                for (int i = 1; i <= judgesNum; i++)
                {        
                    grades = double.Parse(Console.ReadLine());
                   currentGrades += grades;
                    if (i == judgesNum)
                    {
                        double currentAverageGrade = currentGrades * 1.00 / judgesNum * 1.00;
                        Console.WriteLine($"{presentationName:F2} - {currentAverageGrade:F2}.");
                    }
                    
                    averageGradeSum += grades;
                }
                input = Console.ReadLine();
            }
            averageGrade = averageGradeSum * 1.00 / (judgesNum * 1.00 * presentationsCounter * 1.00);
            Console.WriteLine($"Student's final assessment is {averageGrade:F2}.");
        }
    }
}
