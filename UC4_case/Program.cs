using System;

namespace UC4_case
{
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHr = 20;
        static void Main(string[] args)
        {
            

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 2);
            switch(empCheck)
            {
                case isPartTime:
                    empHrs = 8;
                    break;
                case isFullTime:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                break;
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine(empWage);
        }
    }
}
