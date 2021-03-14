using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC10_Using_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject empWageBuilder = new EmpWageBuilderObject();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.ReadKey();

        }

    }
}
