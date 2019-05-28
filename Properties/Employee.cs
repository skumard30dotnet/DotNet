using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Employee
    {
        public int temp = 0;
        int empId = 0;
        string empName = string.Empty;

        public int EmpId { get; set; }

        //private int myVar;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

    }
}
