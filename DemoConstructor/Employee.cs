using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConstructor
{
    class Employee
    {
        string name;
        int age;

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Employee(Employee emp)
        {
            name = emp.name;
            age = emp.age;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("The employee Name is {0}", name);
            Console.WriteLine("The age of the Employee is {0}", age);
        }


    }
}
