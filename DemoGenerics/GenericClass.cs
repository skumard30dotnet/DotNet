using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    class GenericClass<T> where T : class
    {
        private T genericMemberVariable;

        public GenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T GenericMethod(T parameter)
        {
            Console.WriteLine("Data Member Variable value is {0}, Type of Data Member {1}", genericMemberVariable, typeof(T).ToString());
            Console.WriteLine("Method Parameter value is {0}, Type of Parameter {1}", parameter, typeof(T));

            return genericMemberVariable;
        }

        public T GenericProperty { get; set; }
    }
}
