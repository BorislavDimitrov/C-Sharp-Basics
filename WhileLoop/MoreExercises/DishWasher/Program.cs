using System;

namespace DishWasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int preparationBottles = int.Parse(Console.ReadLine());
            int preparationQuanity = preparationBottles * 750;
            string input = Console.ReadLine();
            int dishes = 0;
            int pots = 0;
            int counter = 1;
            int num;

            int preparationForDishes = 0;
            int preparationForPots = 0;
            int totalPreparationNeeded = 0;
            int difference = 0;

            while (input != "End" )
            {
                num = int.Parse(input);
                if (counter % 3 == 0)
                {
                    pots += num;
                }
                else 
                {
                    dishes += num;
                }

                preparationForDishes = dishes * 5;
                preparationForPots = pots * 15;
                totalPreparationNeeded = preparationForPots + preparationForDishes;
                difference = preparationQuanity - totalPreparationNeeded;

                if (totalPreparationNeeded > preparationQuanity)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(difference)} ml. more necessary!");
                    break;
                }

                counter++;
                input = Console.ReadLine();
            }

            if (preparationQuanity >= totalPreparationNeeded)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {difference} ml.");
            }
            
        }
    }
}
