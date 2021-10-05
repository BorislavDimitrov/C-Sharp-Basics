using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (score > 1000)
            {
                bonus = score * 10.0 / 100;
            }
            else if (score > 100)
            {
                bonus = score * 20.0 / 100;
            }
            else if(score <= 100)
            {
                bonus += 5;
            }
            


            if (score % 2 == 0)
            {
                bonus += 1;
            }

            if (score % 10 == 5)
            {
                bonus += 2;
            }
            double sum = score + bonus;
            Console.WriteLine(bonus);
            Console.WriteLine(sum);
        }
    }
}
