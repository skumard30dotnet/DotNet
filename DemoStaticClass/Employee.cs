using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStaticClass
{
  
    static class Employee
    {
        static string empInfo = string.Empty;

        public static int empId { get; set; }
        public static string empName { get; set; }

        public static void DisplayEmployeeDetails()
        {
            empInfo = string.Format("The Employee Id is {0} and Employee Name is {1}", empId, empName);
            Console.WriteLine(empInfo);
        }
    }
}
