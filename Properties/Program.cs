using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            //emp.EmpId = 10;
            emp.EmpName = "Kumar";

            Console.WriteLine("Employee Id is : {0}", emp.EmpId);
            Console.WriteLine("Employee Name is : {0}", emp.EmpName);

            Console.Read();
        }
    }
}
