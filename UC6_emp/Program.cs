using System;

namespace UC6_emp
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int maxHrsInMonth = 100;
        public const int maxDaysInMonth = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;

            Random random = new Random();
            int empCheck = random.Next(1, 2);
            switch(empCheck)
            {
                case isPartTime:
                    empHrs = 4;
                    break;
                case isFullTime:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;    
            }
            int totalWorkingHrs = empHrs + maxHrsInMonth;
            totalWorkingDays = totalWorkingHrs * maxDaysInMonth;
            Console.WriteLine(totalWorkingDays);
        }
    }
}
