using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Employee emp = new Employee();
            emp.Add(10, 20);
            emp.Add("Hello", "World");

        }
    }
}
