using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStaticConstReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticConstReadOnly scr = new StaticConstReadOnly();
            double pi = StaticConstReadOnly.pi;
            scr.normalVariable = "SCRObject1";
            StaticConstReadOnly.dollarRate = 65;

            StaticConstReadOnly scr2 = new StaticConstReadOnly();
            scr2.normalVariable = "SCRObject2";
            StaticConstReadOnly.dollarRate = 70;


        }
    }
}
