using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class PartialClass
    {
        public void Create()
        {
            Console.WriteLine("Created Successfully");
        }
        public void Update()
        {
            Console.WriteLine("Updated Successfully");
        }
    }

    partial class PartialClass
    {
        public void Get()
        {
            Console.WriteLine("Loaded Successfully");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted Successfully");
        }
    }

}
