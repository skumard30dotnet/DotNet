using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericClass<int> genericClass = new GenericClass<int>(100);
            //genericClass.GenericMethod(1000);
            //genericClass.GenericProperty = 500;

            Console.WriteLine("---------------------------------------------------------------");

            GenericClass<string> genericClassString = new GenericClass<string>("Hello World");
            genericClassString.GenericMethod("Welcome to Generics");

            GenericDictionaryKeyValue<int, string> genericDictionaryKeyValue = new GenericDictionaryKeyValue<int, string>(3199, "Rajesh");
            genericDictionaryKeyValue.GenericMethod(3200);


            Console.Read();

            List<int> lst = new List<int>();
            IList<int> IList = new List<int>();

            //Employee emp = new Employee();
            //emp.Add(10, 20);
            //emp.Add("Hello", "World");

        }
    }
}
