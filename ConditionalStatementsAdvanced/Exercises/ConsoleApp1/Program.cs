using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първият ред съдържа час на изпита – цяло число от 0 до 23.
            // Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            // Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            // Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.

            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            int examTime = examMin + examHour * 60; //chasa na izpita v minyti
            int arriveTime = arriveMin + arriveHour * 60; // chasa na pristigane v minyti
            double difference = examTime - arriveTime;
            Console.WriteLine(difference);
            if (difference < 0)
            {
                Console.WriteLine("Late");
                if (Math.Abs(difference) < 60)
                {
                    if ((Math.Abs(difference) % 60 < 10) || ((Math.Abs(difference) / 60 < 1 &&  ))
                    {
                        Console.WriteLine($"0:{difference}");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Abs(difference) / 60}:{Math.Abs(difference) % 60}");    
                    } 
                    
                }
                
                
                    
                
            }
            else if (examTime <= arriveTime || (arriveTime - examTime <= 30 && arriveTime - examTime > 0))
            {
                Console.WriteLine("On time");
            }
            else if (arriveTime - examTime > 30 && arriveTime - examTime >0)
            {
                Console.WriteLine("Early");
            }

            
 
        }
    }
}
