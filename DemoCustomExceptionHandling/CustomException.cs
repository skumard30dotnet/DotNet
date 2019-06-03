using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCustomExceptionHandling
{
    class CustomException : Exception
    {
        string exception = string.Empty;

        public CustomException(string msg)
        {
            exception = msg;
        }

        public string CustException()
        {
            return "Error Occured, Custom Exception " + exception;
        }
    }
}

