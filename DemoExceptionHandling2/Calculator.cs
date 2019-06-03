using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptionHandling2
{
    class Calculator
    {
        public void Divide(int numerator, int denominator)
        {
            int result = 0;
            try
            {
                result = numerator / denominator;
                Console.WriteLine("The result is {0}", result);
            }
            catch (DivideByZeroException e)
            {
                throw;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Not Found, Please check the file is exist");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured, Please contact System Administrator : {0}", e.Message);
            }

        }
    }
}
