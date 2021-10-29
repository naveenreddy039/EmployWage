using System;

namespace UC5_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int maxHoursInMonth = 20;
            int maxWorkingDaysInMonth = 20;
            int empRatePerDay = 20;

            int totalEmpHrs = 0;
            int totalWorkingHors = 0;
            int workingHrs;

            Random random = new Random();
            int empCheck = random.Next(1, 2);
            if(empCheck==isFullTime)
            {
                workingHrs = 8;
            }
            else if(empCheck==isPartTime)
            {
                workingHrs = 4;
            }
            else
            {
                workingHrs = 0;
            }
            int totalWorkingHrs = workingHrs * maxHoursInMonth;
            int totalSalary = totalWorkingHrs * empRatePerDay;
            Console.WriteLine(totalSalary);
        }
    }
}
