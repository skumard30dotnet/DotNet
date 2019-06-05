using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    class GenericDictionaryKeyValue<T, U> where T : struct where U : class
    {
        private T genericMemberKey;
        private U genericMemberValue;

        public GenericDictionaryKeyValue(T key, U value) 
        {
                genericMemberKey = key;
                genericMemberValue = value;
        }

        public T GenericMethod(T parameter)
        {
            Console.WriteLine("Data Member Variable value is {0}, Type of Data Member {1}", genericMemberKey, typeof(T).ToString());
            Console.WriteLine("Method Parameter value is {0}, Type of Parameter {1}", parameter, typeof(T));

            return genericMemberKey;
        }

        public T GenericProperty { get; set; }
    }
}
