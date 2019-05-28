using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethodOverriding
{
    class Parent
    {
        public void Singer()
        {
            Console.WriteLine("I am not a professional singer + Parent Class Method");
        }

    }

    class Child : Parent
    {
        public new void Singer()
        {
            Console.WriteLine("I am not a professional singer + Child Class Method");
        }
    }
}
