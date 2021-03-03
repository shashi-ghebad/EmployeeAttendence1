using System;

namespace EmployeeWageNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_full_time = 1;
            int emp_rate_per_hour = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == is_full_time)
                empHrs = 8;
            //else
            //empHrs =8;
            empWage = empHrs * emp_rate_per_hour;
            Console.WriteLine("emp wage: "+empWage);
            Console.ReadKey();

        }
    }
}
