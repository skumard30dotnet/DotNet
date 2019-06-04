using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvents
{
    // This is Publisher Class
    class AddTwoNumbers
    {
        public delegate void dg_OddNumber(); // Declaration of delegate
        public event dg_OddNumber ev_OddNumber;

        public void Add()
        {
            int result = 0;
            result = 5 + 4;

            Console.WriteLine("Result : {0}", result);

            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber();
            }
        }

    }
}
