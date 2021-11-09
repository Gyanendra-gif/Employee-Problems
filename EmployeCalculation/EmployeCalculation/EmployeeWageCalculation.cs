﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeCalculation
{
    class EmployeeWageCalculation
    {
        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, PRESENT = 1, HALF_DAY = 2, TOTAL_DAYS = 20;
        int totalSalary, empHr;
        public void MonthlyEmployeeWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            for (int i = 0; i < totalDays; i++)
                switch (empCheck)
                {
                    case Present:
                        this.empHr += FULL_DAY_HOUR;
                        break;
                    case HalfDay:
                        this.empHr += HALF_DAY_HOUR;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent for the Day");
                        break;
                }

            this.totalSalary = WAGE_PR_HR * empHr;
            Console.WriteLine("Here is the Monthly Salary of Emp." + this.totalSalary);

        }
    }
}
