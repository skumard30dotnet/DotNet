using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByBValueAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeId = 0;
            List<string> empList = new List<string>() { "Kumar", "pragim", "Guna"};

            Employee emp = new Employee();
            employeeId = 5;
            emp.PassByValue(employeeId);
            Console.WriteLine("Initial Value {0}", employeeId);

            empList.Add("Bala");
            emp.PassByReference(empList);
            Console.WriteLine(empList);

        }
    }
}
