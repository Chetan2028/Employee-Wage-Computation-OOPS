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
        public void CalculateDailyWageForPartTimeEmployee()
        {
            int empCheck = random.Next(2);
            int employeeHours;
            if (empCheck == IS_FULL_TIME)
            {
                employeeHours = 8;
                Console.WriteLine("Employee is Full Time");
            }
            else if(empCheck == IS_PART_TIME)
            {
                employeeHours = 4;
                Console.WriteLine("Employee is Part Time");
            }
            else
            {
                employeeHours = 0;
                Console.WriteLine("Employee is Absent");
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
            program.CalculateDailyWageForPartTimeEmployee();
        }
    }
}
