using System;

namespace EmployeeWageComputation
{
    class Program
    {
        ///Constants
        const int IS_PRESENT = 1;
        const int EMPLOYEE_WAGE_PER_HOUR = 20;


        /// Creates a reference of Random Class
        Random random = new Random();

        /// <summary>
        /// Calculates the daily wage for part time employee.
        /// </summary>
        public void CalculateDailyWage()
        {
            int empCheck = random.Next(2);
            int employeeHours;
            if (empCheck == IS_PRESENT)
            {
                employeeHours = 8;
            }
            else
            {
                employeeHours = 0;
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
            program.CalculateDailyWage();
        }
    }
}
