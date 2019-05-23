using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleInheritance
{
    class Child : Parent
    {
        public void Athlet()
        {
            Artist();
            Singer();
            Trainer();
            Console.WriteLine("I am an Athlet");
        }

        public void Swimmer()
        {
            Console.WriteLine("I am an Swimmer");
        }
    }
}
