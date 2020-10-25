using System;

namespace EmployeeWageComputation
{
    class Program
    {
        ///Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        const int EMPLOYEE_WAGE_PER_HOUR = 20;


        /// Creates a reference of Random Class
        Random random = new Random();

        /// <summary>
        /// Calculates the daily wage for part time employee.
        /// </summary>
        public void CalculateDailyWageUsingSwitch()
        {
            int empCheck = random.Next(3);
            int employeeHours = 0;
            switch (empCheck)
            {
                case IS_PART_TIME:
                    Console.WriteLine("EMployee is part timee");
                    employeeHours = 4;
                    break;
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is Full Time");
                    employeeHours = 8;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    employeeHours = 0;
                    break;
            }
            Console.WriteLine("Employee Daily Wage is : " + employeeHours * EMPLOYEE_WAGE_PER_HOUR);
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CalculateDailyWageUsingSwitch();
        }
    }
}
