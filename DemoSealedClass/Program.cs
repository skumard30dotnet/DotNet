using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass sealedClass = new SealedClass();
            sealedClass.Add();
            sealedClass.Display();

            Console.Read();

        }
    }
}
