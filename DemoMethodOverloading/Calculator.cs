using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethodOverloading
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("The sum is : {0}", a + b);
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine("The sum is : {0}", a + b);
        }

        public void Add(string a, string b)
        {
            Console.WriteLine("The sum is : {0}", a + b);
        }

        public void Add(string a, int b)
        {
            Console.WriteLine("The sum is : {0}", a + b);
            Console.WriteLine();


        }
    }
}
