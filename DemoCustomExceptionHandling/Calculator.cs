using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCustomExceptionHandling
{
    class Calculator
    {
        public void Divide(int numerator, int denominator)
        {
            int result = 0;
            try
            {
                throw new CustomException("Numerator cannot be zero");
            }
            catch (CustomException e)
            {
                string msg = e.CustException();
            }
            catch (Exception e)
            {

            }

        }
    }
}
