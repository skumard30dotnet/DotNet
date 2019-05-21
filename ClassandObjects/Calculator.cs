using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjects
{
    /// <summary>
    /// 
    /// </summary>
    class Calculator
    {
        int a = 0;
        int b = 0;
        int result = 0; // Data Member

        public Calculator()
        {

        }

        public Calculator(int x, int y)
        {
            a = x;
            b = y;
        }


        /// <summary>
        /// Addition of two numbers
        /// </summary>
        /// <param name="a">passing integer datatype</param>
        /// <param name="b"></param>
        public void Add()
        {
            result = a + b;
            PrintValues(a, b, result, "Sum");
        }

        public void Sub()
        {
            result = a - b;
            PrintValues(a, b, result, "Sub");
            //Console.WriteLine("The sub of a:{0} , b:{1} = {2}", a, b, result);
        }

        public void Mul()
        {
            result = a * b;
            PrintValues(a, b, result, "Mul");
            //Console.WriteLine("The Mul of a:{0} , b:{1} = {2}", a, b, result);
        }

        public void Div()
        {
            result = a / b;
            PrintValues(a, b, result, "Div");

            //Console.WriteLine("The sub of a:{0} , b:{1} = {2}", a, b, result);
        }

        void PrintValues(int a, int b, int result, string type)
        {
            Console.WriteLine("The value of A is {0}", a);
            Console.WriteLine("The value of B is {0}", b);
            Console.WriteLine("The {0} is : {1}", type, result);
            Console.WriteLine("**********************************************");
        }

        /*
        /// <summary>
        /// Addition of two numbers
        /// </summary>
        /// <param name="a">passing integer datatype</param>
        /// <param name="b"></param>
        public void Add(int a, int b) 
        {
            result = a + b;
            PrintValues(a, b, result);
        }

        public void Sub(int a, int b)
        {
            result = a - b;
            PrintValues(a, b, result);
            //Console.WriteLine("The sub of a:{0} , b:{1} = {2}", a, b, result);
        }

        public void Mul(int a, int b)
        {
            result = a * b;
            PrintValues(a, b, result);
            //Console.WriteLine("The Mul of a:{0} , b:{1} = {2}", a, b, result);
        }

        public void Div(int a, int b)
        {
            result = a / b;
            PrintValues(a, b, result);
            
            //Console.WriteLine("The sub of a:{0} , b:{1} = {2}", a, b, result);
        }

        void PrintValues(int a, int b, int result)
        {
            Console.WriteLine("The value of A is {0}", a);
            Console.WriteLine("The value of B is {0}", b);
            Console.WriteLine("The result is : {0}", result);
            Console.WriteLine("**********************************************");
        }
        */
    }
}
