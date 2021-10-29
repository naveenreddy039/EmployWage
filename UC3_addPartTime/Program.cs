using System;

namespace UC3_addPartTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1;
            int partTimeWagePerHr = 8;

            int partTime = 0;
            int partTimeEmpWage = 0;
            Random random = new Random();
            int empCheck = random.Next(1, 2);
            if(empCheck==isPartTime)
            {
                partTime = 4;
            }
            else
            {
                partTime = 0;
            }
            partTimeEmpWage = partTime * partTimeWagePerHr;
            Console.WriteLine("parttime emp wage:"+partTimeEmpWage);
            Console.ReadKey();
        }
    }
}
