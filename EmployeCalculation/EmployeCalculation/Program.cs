using System;

namespace EmployeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmpWageBuilderObject infosys = new EmpWageBuilderObject("Infosys", 10, 50, 200);
            EmpWageBuilderObject wipro = new EmpWageBuilderObject("Wipro", 30, 54, 150);
            infosys.computeEmpWage();
            Console.WriteLine(infosys.toString());
            wipro.computeEmpWage();
            Console.WriteLine(wipro.toString());
        }
    }
}