using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForTheTrip = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            string saveOrSpend= "";
            double saveOrSpendSum = 0.0;
            int spendDaysCounter = 0;
            int daysCounter = 0;

            while (currentMoney < moneyNeededForTheTrip)
            {
                saveOrSpend = Console.ReadLine();
                saveOrSpendSum = double.Parse(Console.ReadLine());
                daysCounter++;
                if (saveOrSpend == "save")
                {
                    currentMoney += saveOrSpendSum;
                    spendDaysCounter = 0;
                }
                else if (saveOrSpend == "spend")
                {             
                    currentMoney -= saveOrSpendSum;
                    spendDaysCounter++;
                    if (spendDaysCounter == 5)
                    {                      
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(daysCounter);
                        break;
                    }
                }
                if (currentMoney <= 0)
                {
                    currentMoney = 0;
                }
                
            }

            if (currentMoney >= moneyNeededForTheTrip)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
