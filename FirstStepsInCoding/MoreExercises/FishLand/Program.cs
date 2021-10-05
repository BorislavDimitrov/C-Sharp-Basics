using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            //•	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            //•	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            //•	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            //•	Пети ред – килограма миди. Цяло число в интервала[0... 100]

            //•	Паламуд – 60 % по - скъп от скумрията
            //•	Сафрид – 80 % по - скъп от цацата
            //•	Миди – 7.50 лв.за килограм

            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            double shellKg = double.Parse(Console.ReadLine());

            double bonito = bonitoKg * (mackerelPrice+ mackerelPrice * 60 / 100);
            double scad = scadKg * (spratPrice + spratPrice * 80 / 100);
            double shells = shellKg * 7.50;

            double sum = bonito + scad + shells;
            Console.WriteLine($"{sum:F2}");



        }
    }
}
