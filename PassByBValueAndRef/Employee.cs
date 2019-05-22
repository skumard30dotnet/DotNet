using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByBValueAndRef
{
    class Employee
    {
        public void PassByValue(int employeeId)
        {
            Console.WriteLine("Employee Id is {0}", employeeId);
            employeeId = 10;
            Console.WriteLine("Employee Id is {0} after the value got modified", employeeId);
        }


        public void PassByReference(List<string> employee)
        {
            Console.WriteLine("Employee is {0}", employee);
            employee[0] = "New Value";
            Console.WriteLine("Employee Id is {0} after the value got modified", employee);
        }
    }
}
