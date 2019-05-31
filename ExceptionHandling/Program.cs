using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Divide(10, 0);

            Console.Read();
        }
    }
}
