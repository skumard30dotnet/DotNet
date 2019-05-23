using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Ravi", 24);
            Employee emp2 = new Employee(emp1);
            emp2.PrintEmployee();

            Console.Read();
        }
    }
}
