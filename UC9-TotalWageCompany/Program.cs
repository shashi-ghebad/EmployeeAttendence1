using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("NOKIA", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("SAMSUNG", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
            Console.ReadKey();
        }

    }
}