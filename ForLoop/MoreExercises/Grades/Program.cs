using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double grade = 0.0;

            int twoToThreeCounter = 0;
            int threeToFourCounter = 0;
            int fourToFiveCounter = 0;
            int fiveToSixCounter = 0;
            double averageCounter = 0.0;

            for (int i = 1; i <= students; i++)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 2.00 && grade <= 2.99)
                {
                    twoToThreeCounter++;
                    averageCounter += grade;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    threeToFourCounter++;
                    averageCounter += grade;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    fourToFiveCounter++;
                    averageCounter += grade;
                }
                else if (grade >= 5.00)
                {
                    fiveToSixCounter++;
                    averageCounter += grade;
                }
                
            }

            
            double twoToThreePercent = twoToThreeCounter * 1.00 / students * 100;
            double threeToFourPercent = threeToFourCounter * 1.00 / students * 100;
            double fourToFivePercent = fourToFiveCounter * 1.00 / students * 100;
            double fiveToSixPercent = fiveToSixCounter * 1.00 / students * 100;

            double averageGrade = averageCounter / students;


            Console.WriteLine($"Top students: {fiveToSixPercent:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourToFivePercent:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeToFourPercent:F2}%");
            Console.WriteLine($"Fail: {twoToThreePercent:F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}
