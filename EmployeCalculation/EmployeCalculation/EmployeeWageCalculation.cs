using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeCalculation
{
    class EmployeeWageCalculation
    {
        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, Present = 1, HalfDay = 2;
        int totalSalary;
        public void EmployeeDailyWag()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            switch (empCheck)
            {
                case Present: totalSalary = WAGE_PR_HR * FULL_DAY_HOUR;
                    Console.WriteLine("Employee is Present and salary is: "+totalSalary);
                    break;
                case HalfDay: totalSalary = WAGE_PR_HR * HALF_DAY_HOUR;
                    Console.WriteLine("Employee is Present For HalfDay and salary is: " + totalSalary);
                    break;
                default:
                    Console.WriteLine("Employee is Absent for the Day");
                    break;

            }

            /*if (empCheck == 1)
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
                Console.WriteLine("Employee is Absent");*/
        }
    }
}
