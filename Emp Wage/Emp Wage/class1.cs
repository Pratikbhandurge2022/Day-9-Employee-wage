using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8_1
{
    internal class EmployeeWage
    {
        public const int IsPartTime = 2;
        public const int IsFullTime = 1;
        public const int IsAbsent = 0;

        public void GetEmployeeWage()
        {
            int Totalwage = 0;
            int WagePerHr = 20;
            int NumberOfDaysPerMonth = 20;
            int Hrs = 100;
            int WorkingDays = 0;
            int NoOfHrs = 0;

            while (WorkingDays <= 20 && NoOfHrs <= Hrs)
            {
                WorkingDays++;
                Random random = new Random();
                int number = random.Next(0, 3);
                EmployeeWage employeeWage = new EmployeeWage();
                int empHrs = employeeWage.GetEmpHrs(number);
                NoOfHrs = NoOfHrs + empHrs;

                Totalwage = Totalwage + WagePerHr * empHrs;
            }
            Console.WriteLine("Total wage is " + Totalwage);
        }

        public int GetEmpHrs(int number)
        {
            int empHrs = 0;
            switch (number)
            {
                case IsFullTime:
                    empHrs = 8;

                    break;
                case IsPartTime:
                    empHrs = 4;
                    break;
                case IsAbsent:
                    empHrs = 0;
                    break;

            }
            return empHrs;

        }

    }
}