using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public delegate int Operations(int a, int b);

    class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Operations opp = new Operations(Program.Add);
            int x = opp(10, 20);
            Console.WriteLine("The result is {0}", x);

            Program p = new Program();
            Operations oopSub = new Operations(p.Sub);
            x = oopSub(20, 10);
            Console.WriteLine("The result Sub is  {0}", x);

            Console.Read();
        }
    }
}
