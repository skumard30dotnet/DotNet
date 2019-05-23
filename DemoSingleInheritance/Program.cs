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
            Parent p = new Parent();
            p.Artist();
            p.Singer();

            Child ch = new Child();
            ch.Artist();
            ch.Athlet();
            ch.Singer();
            ch.Swimmer();
            Console.Read();
        }
    }
}
