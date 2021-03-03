using System;

namespace UC3_PartTimeEmpWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int is_part_time = 1;
            const int is_full_time = 2;
            int emp_rate_per_hour = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case is_part_time:
                    empHrs = 4;
                    break;
                case is_full_time:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * emp_rate_per_hour;
            Console.WriteLine("emp wage: " + empWage);
            Console.ReadKey();
        }
    }
}
