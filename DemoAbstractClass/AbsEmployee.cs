using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstractClass
{
    class c1
    {

    }
    interface i1
    { }
    abstract class BaseClass
    {
        public abstract bool Create(string fName, string lName);
        public abstract void Update();
        public abstract void Delete();
        public abstract void Get();

        public void Display(string classType, string recordType)
        {
            Console.WriteLine("The {0} record has been {1} Successfully", classType, recordType);
        }
    }

    class Employee : BaseClass, i1
    {
        const string classType = "Employee";
        string recordType = string.Empty;
        bool isSuccess = false;

        public override bool Create(string fName, string lName)
        {
            recordType = "Created";

            if (ValidateEmployee(fName, lName))
            {
                // Database call
                Display(classType, recordType);
                isSuccess = true;
            }

            return isSuccess;
        }

        public override void Delete()
        {
            recordType = "Deleted";
            // Save to database
            Display(classType, recordType);
        }

        public override void Get()
        {
            recordType = "Fetched";
            // Save to database
            Display(classType, recordType);
        }

        public override void Update()
        {
            recordType = "Updated";
            // Save to database
            Display(classType, recordType);
        }

        private bool ValidateEmployee(string fName, string lName)
        {
            bool isValid = false;

            if (!string.IsNullOrEmpty(fName) && !string.IsNullOrEmpty(lName))
            {
                isValid = true;
            }

            return isValid;
        }
    }

    class Student : BaseClass
    {
        const string classType = "Student";
        string recordType = string.Empty;

        public override bool Create(string fName, string lName)
        {
            recordType = "Created";
            // Save to database
            Display(classType, recordType);

            return true;
        }

        public override void Delete()
        {
            recordType = "Deleted";
            // Save to database
            Display(classType, recordType);
        }

        public override void Get()
        {
            recordType = "Fetched";
            // Save to database
            Display(classType, recordType);
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
