using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.empId = 101;
            Employee.empName = "Pragim";
            Employee.DisplayEmployeeDetails();

            EmployeeNonStaticClass employeeNonStatic = new EmployeeNonStaticClass();
            employeeNonStatic.empId = 100;
            employeeNonStatic.Salary = 100000;
            employeeNonStatic.DisplaySalary();

            EmployeeNonStaticClass.empName = "Mahesh";
            EmployeeNonStaticClass.DisplayEmployeeDetails();

            Console.Read();
        }
    }
}
