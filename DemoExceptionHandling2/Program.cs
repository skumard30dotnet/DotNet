using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            try
            {
                //int a, b;
                //a = 10;
                //b = 0;
                //int x = a / b;
                calc.Divide(10, 0);

               

            }
            catch (Exception e)
            {
                Console.WriteLine("Error Occured, {0}", e.Message);
                Console.WriteLine("Error Occured, {0}", e.StackTrace);
            }

            Console.Read();
        }
    }
}
