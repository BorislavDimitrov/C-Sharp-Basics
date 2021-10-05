using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред: число за преобразуване - реално число
            //•	Втори ред: входна мерна единица - текст
            //•	Трети ред: изходна мерна единица(за резултата) - текст
            double num = double.Parse(Console.ReadLine());
            string enterType = Console.ReadLine();
            string outputType = Console.ReadLine();

            //1 meter(m) 1000 millimeters(mm)
            //1 meter(m) 100 centimeters(cm)

            if (enterType == "m" && outputType == "cm")
            {
                num = num * 100;
            }
            else if (enterType == "m" && outputType == "mm")
            {
                num = num * 1000;
            }

            if (enterType == "cm" && outputType == "m")
            {
                num = num / 100;
            }
            else if (enterType == "cm" && outputType == "mm")
            {
                num = num * 10;
            }

            if (enterType == "mm" && outputType == "m")
            {
                num = num / 1000;
            }
            else if (enterType == "mm" && outputType == "cm")
            {
                num = num / 10;
            }

            Console.WriteLine($"{num:F3}");
        }
    }
}
