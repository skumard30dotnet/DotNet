using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleInheritance
{
    class Child : Parent
    {
        private class test { }
        int meters;
        string type;
        string instrument;

        private Child(int meters, string type, string instrument) : base(type, instrument)
        {
            this.meters = 100;
           
        }

        public void Athlet()
        {
            Artist();
            Singer();
            Trainer();
            Console.WriteLine("I am an Athlet : {0} M", this.meters);
        }

        public void Swimmer()
        {
            Console.WriteLine("I am an Swimmer");
        }
    }
}
