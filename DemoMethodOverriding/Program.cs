using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Child ch = new Child();
            ch.Singer();

            Parent p = new Child();
            p.Singer();

            Console.Read();
        }
    }
}
