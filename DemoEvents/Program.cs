using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvents
{
    // Subsciber Class
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(Program.EventMessage);
            a.Add();
            Console.Read();
            //this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        // Delegate calls this method when the events gets triggered
        static void EventMessage()
        {
            Console.WriteLine("Event Executed");
        }
    }
}
