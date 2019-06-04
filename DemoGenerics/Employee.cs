using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    class Employee
    {


        int a, b;

        public Employee(int a, int b)
        {
            this.a = a;
        }


        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public void Add(dynamic a, dynamic b)
        {
            var result = a + b;
        }
    }
}
