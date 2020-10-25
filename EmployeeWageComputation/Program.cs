using System;

namespace EmployeeWageComputation
{
    class Program
    {
        ///Constants
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        const int EMPLOYEE_WAGE_PER_HOUR = 20;
        const int MAXIMUM_WORKING_HOURS = 100;
        const int MAXIMUM_WORKING_DAYS = 20;

        /// Creates a reference of Random Class
        Random random = new Random();

        /// <summary>
        /// Calculates the daily wage for part time employee.
        /// </summary>
        public void CalculateMonthlyWages()
        {
            int employeeHours = 0;
            int totalEmployeeHours = 0;
            int totalWorkingDays = 0;
            
            while (totalWorkingDays < MAXIMUM_WORKING_DAYS && totalEmployeeHours < MAXIMUM_WORKING_HOURS)
            {
                totalWorkingDays++;
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        employeeHours = 4;
                        break;

                    case IS_FULL_TIME:
                        employeeHours = 8;
                        break;

                    default:
                        employeeHours = 0;
                        totalWorkingDays--;
                        break;
                }
                totalEmployeeHours += employeeHours;
            }
            Console.WriteLine("Employee Daily Wage is : " + totalEmployeeHours * EMPLOYEE_WAGE_PER_HOUR);
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CalculateMonthlyWages();
        }
    }
}
