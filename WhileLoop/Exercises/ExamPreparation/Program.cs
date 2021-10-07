using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradesNum = int.Parse(Console.ReadLine());
            int exerciseCount = 0;
            int badGrades = 0;
            string lastProblem = "";
            double gradeSum = 0;
            string exerciseName = Console.ReadLine();
            double grade = 0.0; 
            while (badGrades < badGradesNum && exerciseName != "Enough")
            {
                grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGrades++;
                }
                gradeSum += grade;
                exerciseCount++;
                 lastProblem = exerciseName;
                
                exerciseName = Console.ReadLine();
                

            }
            if (exerciseName == "Enough")
            {
                double averageScore = gradeSum / exerciseCount;
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {exerciseCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else 
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }
        }
    }
}
