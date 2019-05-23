using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleInheritance
{
    class Parent
    {
        public void Artist()
        {
            Console.WriteLine("I am an Artist");
        }

        public void Singer()
        {
            Console.WriteLine("I am a Singer");
        }

        private void Smoker()
        {
            Console.WriteLine("I am a Singer");
        }

        protected void Trainer()
        {
            Console.WriteLine("I am a Singer");
        }
        

    }
}

