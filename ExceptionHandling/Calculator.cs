using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Calculator
    {
        public void Divide(int numerator, int denominator)
        {
            int result = 0;
            try
            {
                result = numerator / denominator;
                int y = 124349058;
                short x = (short) y;
                Console.WriteLine("The result is {0}", result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            

            
        }
    }
}
