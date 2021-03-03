using System;

namespace UC6_MonthlyWage20Days
{
    class Program
    {
        public static void Main(string[] args)
        {
            int PRESENT = 1;
            int Emp_Rate = 41;
            int empHrs = 8;
            int empWage = 0;
            int Total = 20;
            Random random = new Random();
            for (int i = 1; i <= 41; i++)
            {
                int empCheck = random.Next(1);
                if (empCheck == PRESENT)
                {
                    Total++;

                }

            }
            empWage = Total * empHrs * Emp_Rate;

            Console.WriteLine("Employee Wages For " + Total + " Working Days " + empWage);
        }
    }
}
