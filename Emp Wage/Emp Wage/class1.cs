using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8_1
{
    internal class EmployeeWage
    {
        public static int WagePerHour = 20;
        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to Employee Wage Computation  Program on Master Branch");
        }

        public static void GetAttendance()
        {
            Random random = new Random();
            int number = random.Next(0, 3);
            CheckAttendance(number);
        }

        public static void CheckAttendance(int number)
        {
            int salary = 0;
            switch (number)
            {
                case 0:
                    Console.WriteLine("Empoyee is absent");
                    salary = WagePerHour * 0;
                    break;
                case 1:
                    Console.WriteLine("Employee is present part time");
                    salary = WagePerHour * 4;
                    break;
                case 2:
                    Console.WriteLine("Employee is present full time");
                    salary = WagePerHour * 8;
                    break;
            }

            Console.WriteLine("Salary is " + salary);
        }
    }
}