using System;

namespace Hospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int patients;
            int doctors = 7;
            int treatedPatiens = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatients > treatedPatiens)
                {
                    doctors++;
                }

                if (patients >= doctors)
                {
                    treatedPatiens += doctors;
                }
                else
                {
                    treatedPatiens += patients;
                }

                if (patients > doctors)
                {
                    untreatedPatients += patients - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatiens}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
