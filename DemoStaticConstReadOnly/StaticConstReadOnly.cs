using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStaticConstReadOnly
{
    class StaticConstReadOnly
    {
        public string normalVariable = "initial Value";
        public const double pi = 3.14;
        public static double dollarRate = 0;
        public readonly double goldRatePerGram = 2790;

        public StaticConstReadOnly()
        {
            goldRatePerGram = 2900;
        }

    }
}
