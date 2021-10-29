using System;

namespace EmployeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPartTime = 1;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(isPartTime==empCheck)
            {
                Console.WriteLine("Employ is present");
            }
            else
            {
                Console.WriteLine("Employe is absent");
            }
            Console.ReadKey();
        }
    }
}
