using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            bool isSuccess = emp.Create("Ravi", "");
            emp.Update();
            emp.Get();
            emp.Delete();
            

            Console.WriteLine("-------------------------------------------");

            Student stud = new Student();
            isSuccess = emp.Create("Ravi", "Kumar");
            //stud.Update();
            stud.Get();
            stud.Delete();

            Console.Read();
        }
    }
}
