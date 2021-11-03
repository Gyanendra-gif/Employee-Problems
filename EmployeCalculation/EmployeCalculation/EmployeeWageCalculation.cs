using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeCalculation
{
    class EmployeeWageCalculation
    {
        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4;
        int totalSalary;
        public void EmployeeDailyWag()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            if (empCheck == 1)
            {
                this.totalSalary = WAGE_PR_HR * FULL_DAY_HOUR;
                Console.WriteLine("Employee is Present and Salary is: " + this.totalSalary);
            }
            if (empCheck == 2) 
            {
                this.totalSalary = WAGE_PR_HR * HALF_DAY_HOUR;
                Console.WriteLine("Employee is Present for Half Day and Salary is: " + this.totalSalary);
            }

            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
