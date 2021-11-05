using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage10
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHr;
        public int numberOfWorkingDays;
        public int maxHrsPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(String company, int empRatePerHr, int numberOfWorkingDays, int numberOfHrsInMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
            Console.WriteLine(this.totalEmpWage);
        }
        public String toString()
        {
            return "total Emp wage for Company" + this.company + "is:" + this.totalEmpWage;
        }
    }
    
}
