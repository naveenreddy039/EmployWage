using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage10
{
    public class EmpWageBuilder
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        private int NumberOfCompany = 0;
        private CompanyEmpWage[] CompanyEmpWage;

        public EmpWageBuilder()
        {
            this.CompanyEmpWage=new EmpWage10.CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(String company,int empRatePerHr,int numberOfWorkingDays,int numberOfHrsInMonth)
        {
            CompanyEmpWage[this.NumberOfCompany] = new CompanyEmpWage(company, empRatePerHr, numberOfWorkingDays, numberOfHrsInMonth);
            NumberOfCompany++;
        }
        public void computeEmpWage()
        {
            for(int i=0;i<NumberOfCompany;i++)
            {
                CompanyEmpWage[i].setTotalEmpWage(this.computeEmpWage(this.CompanyEmpWage[i]));
            }
        }
        private int computeEmpWage(CompanyEmpWage CompanyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= CompanyEmpWage.maxHrsPerMonth && totalWorkingDays <= CompanyEmpWage.numberOfWorkingDays)
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
            return totalEmpHrs = CompanyEmpWage.empRatePerHr;
        }
    }
}
