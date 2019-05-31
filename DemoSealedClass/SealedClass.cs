using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSealedClass
{
    class BaseClass
    {
        public void Display()
        {

        }
    }
    sealed class SealedClass : BaseClass
    {
        public void Add()
        {

        }

        public void Sub()
        {

        }
    }

    
    //class DerivedClass : SealedClass
    //{

    //}
}
