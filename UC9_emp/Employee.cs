using System;
using System.Collections.Generic;
using System.Text;

namespace UC9_emp
{
    public class Employee
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        private String name;
        public int empRatePerHr;
        public int maxWorkingDays;
        public int maxHrsInMonth;
        public int totalEmpWage;

       
        public Employee(string name,int empRatePerHr,int maxWorkingDays,int maxHrsInMonth)
        {
            
            this.name = name;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }
        public void empWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays <= maxWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(1, 2);
                switch (empCheck)
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
                totalEmpHrs = empHrs + totalEmpHrs;
                Console.WriteLine(totalWorkingDays);
                Console.WriteLine(empHrs);
            }
            int totalEmpWage = totalEmpHrs * this.empRatePerHr;
            Console.WriteLine(totalEmpWage);
        }
        public string toSting()
        {
            return "total emp wage for " + this.name + "is:" + this.totalEmpWage;
        }
    }
}
