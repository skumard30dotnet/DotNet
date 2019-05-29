using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class c1
    {

    }
    class c2
    {

    }

    interface ICR
    {
        void Create();
        void Read();
        void Print();
    }

    interface IUD
    {
        void Update();
        void Delete();
        void Print();
    }

    class Student : c1, ICR, IUD
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        void ICR.Print()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    class Employee : ICR
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}
