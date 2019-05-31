using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStaticClass
{
    class EmployeeNonStaticClass
    {
        static string empInfo = string.Empty;

        public int empId { get; set; }
        public static string empName { get; set; }
        public int Salary { get; set; }

        public static void DisplayEmployeeDetails()
        {
            empInfo = string.Format("The Employee Id is {0} and Employee Name is {1}",0, empName);
            Console.WriteLine(empInfo);
        }

        public void DisplaySalary()
        {
            Console.WriteLine("The Employee Salary is {0}", Salary);
        }
    }
}
