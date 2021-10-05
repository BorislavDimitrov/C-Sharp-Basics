using System;

namespace charityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int daysNum = int.Parse(Console.ReadLine());
            int bakersNum = int.Parse(Console.ReadLine());
            int cakesNum = int.Parse(Console.ReadLine());
            int wafflesNum = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesPerDayPrice = cakesNum * 45;
            double wafflesPerDayPrice = wafflesNum * 5.80;
            double pancakesPerDayPrice = pancakes * 3.20;

            double sumForOneDay = (cakesPerDayPrice + wafflesPerDayPrice + pancakesPerDayPrice) * bakersNum;
            double sumForWholeCampaign = sumForOneDay * daysNum;
            double sumAfterExpenses = sumForWholeCampaign - sumForWholeCampaign / 8;

            Console.WriteLine(sumAfterExpenses);


        }
    }
}
