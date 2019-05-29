using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethodOverridings
{
    class Parent
    {
        public virtual void Singer()
        {
            Console.WriteLine("I am not a professional singer + Parent Class Method");
        }

    }

    class Child : Parent
    {
        public override void Singer()
        {
            string x = "Test";
            Console.WriteLine("I am a professional singer + Child Class Method");
        }
    }
}
