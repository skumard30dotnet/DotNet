using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent();
            //p.Artist();
            //p.Singer();

            //Child ch = new Child();
            //ch.Artist();
            //ch.Athlet();
            //ch.Singer();
            //ch.Swimmer();
            //ch.Swimmer();

            //Parent ch1 = new Child();
            //ch1.Artist();
            //ch1.Musician();
            //ch1.Singer();


            Child ch = new Child(100, "Vocal", "Flute");
            ch.Singer();
            ch.Athlet();
            ch.Musician();


            // This is not allowed in C#
            //Child ch2 = new Parent();

            Console.Read();
        }
    }
}
