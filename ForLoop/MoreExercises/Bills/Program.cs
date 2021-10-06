using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electrycityBill ;
            double waterBill = 20;
            double internetBill = 15;
            double othersBill = 0;

            double electricityBillsSum =0;
            double waterBillsSum = 0;
            double internetBillsSum = 0;
            double othersBillsSum = 0;

            for (int i = 1; i <= months; i++)
            {
                electrycityBill = double.Parse(Console.ReadLine());

                electricityBillsSum += electrycityBill;
                waterBillsSum += waterBill;
                internetBillsSum += internetBill;
                othersBill += (electrycityBill + waterBill + internetBill) * 1.2;
                othersBillsSum += othersBill;
                othersBill = 0;
                

            }
            double average = (electricityBillsSum + waterBillsSum + internetBillsSum + othersBillsSum) / months;

            Console.WriteLine($"Electricity: {electricityBillsSum:F2} lv");
            Console.WriteLine($"Water: {waterBillsSum:F2} lv");
            Console.WriteLine($"Internet: {internetBillsSum:F2} lv");
            Console.WriteLine($"Other: {othersBillsSum:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
