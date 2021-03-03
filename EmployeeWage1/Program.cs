using System;

namespace UC5_MonthlyWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            int PRESENT = 1;
            int Emp_Rate = 41;
            int empHrs = 8;
            int empWage = 0;
            int count = 0;
            Random random = new Random();
            for (int i = 1; i <= 41; i++)
            {
                int empCheck = random.Next(0, 2);
                if (empCheck == PRESENT)
                {
                    count++;

                }

            }
            empWage = count * empHrs * Emp_Rate;

            Console.WriteLine("Employee Wages For " + count + " Working Days " + empWage);
        }
    }
}
