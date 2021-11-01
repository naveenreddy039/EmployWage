using System;

namespace UC9_emp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Employee wipro = new Employee("wipro", 10, 4, 20);
            Employee relince = new Employee("relince", 10, 4, 20);
            wipro.empWage();
            Console.WriteLine(wipro.ToString());
            relince.empWage();
            Console.WriteLine(relince.ToString());
        }
    }
}
