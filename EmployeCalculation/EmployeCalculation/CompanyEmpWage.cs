using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeCalculation
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour, numOfWorkingDays, maxHoursPerMonth, totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "The Total Employee Wage for Company " + this.company + " is " + this.totalEmpWage;
        }
    }
}
