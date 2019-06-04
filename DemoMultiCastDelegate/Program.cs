using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMultiCastDelegate
{
    public delegate void Operations(int a, int b);

    class Program
    {
        Program prg = null;
        public static void Add(int a, int b)
        {
            Console.WriteLine("The sum is {0}", a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine("The sub is {0}", a - b);
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine("The mul is {0}", a * b);
        }

        public void Div(int a, int b)
        {
            Console.WriteLine("The div is {0}", a / b);
        }

        static void Main(string[] args)
        {
            Program prg = new Program();
            Operations opp = new Operations(Program.Add);
            opp += new Operations(prg.Sub);
            opp += new Operations(prg.Mul);
            opp += new Operations(prg.Div);

            opp(20, 12);

            Console.WriteLine("-----------------------------------------------------------------");

            opp -= new Operations(prg.Mul);

            opp.Invoke(20, 5);

            
            Console.Read();
        }
    }
}
