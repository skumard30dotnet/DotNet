using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.WriteLine("Enter the value of A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of B");
            b = int.Parse(Console.ReadLine());

            Calculator cal = new Calculator();

            Calculator calc = new Calculator(a, b);
           

            calc.Add();
            calc.Sub();
            calc.Mul();
            calc.Div();

            //calc.Add(a, b);
            //calc.Sub(a, b);
            //calc.Mul(a, b);
            //calc.Div(a, b);

            Console.Read();
        }
    }
}
