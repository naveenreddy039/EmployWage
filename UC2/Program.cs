using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int empRatePerHour = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 2);
            if(empCheck==isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Empoly Days Wage"+empWage);
            Console.ReadKey();
        }
    }
}
