using System;

namespace EmployeeWageComputation
{
    class Program
    {
        ///Variables
        const int IS_PRESENT = 1;

        /// <summary>
        /// Checks for employee presence.
        /// </summary>
        public void CheckForEmployeePresence()
        {
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CheckForEmployeePresence();
        }
    }
}
