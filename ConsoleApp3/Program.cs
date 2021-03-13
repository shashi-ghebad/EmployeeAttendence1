﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        //public const int EMP_RATE_PER_HOUR = 20;
        //public const int NUM_OF_WORKING_DAYS = 2;
        //public const int MAX_HRS_IN_MONTH = 10;
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " EmpHrs: " + empHrs);
            }
            //Console.WriteLine(totalEmpHrs + "   " + totalWorkingDays);
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
            Console.ReadKey();
        }

    }
}
