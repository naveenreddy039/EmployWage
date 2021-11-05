using System;

namespace EmpWage10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("wipro", 20, 15, 25);
            empWageBuilder.addCompanyEmpWage("reliance", 30, 20, 35);
            empWageBuilder.computeEmpWage();
            //Consloe.WriteLine(totalEmpWage);
        }
    }
}
