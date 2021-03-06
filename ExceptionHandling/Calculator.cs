﻿using System;
using System.Collections.Generic;
using System.IO;
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
                string[] fileArray = File.ReadAllLines("test.txt");

                string[] arry = new string[10];

                Console.WriteLine("The array value is ", arry[12]);

                result = numerator / denominator;
                int y = 124349058;
                short x = (short)y;
                Console.WriteLine("The result is {0}", result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Denominator cannot be zero");
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
