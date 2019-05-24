using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleInheritance
{
    class GrandParent
    {
        string instrument = string.Empty;

        public GrandParent(string instrument)
        {
            this.instrument = instrument;
        }

        public void Musician()
        {
            Console.WriteLine("I am a Musician - {0}", this.instrument);
        }

    }


    class Parent : GrandParent
    {
        string type = string.Empty;

        public Parent(string type, string instrument) : base(instrument)
        {
            this.type = type;
        }
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

