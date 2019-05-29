using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    interface IVechicle
    {
        void ChangeGear(int a);
        void SpeedUp(int a);
        void ApplyBrakes(int a);
    }

    interface IVechicleSpecific
    {
        void EngineType(string type);
        void WheelType(string wheelType);
    }

    class BiCycleWithGear : IVechicle
    {
        int speed = 0;
        int gear = 0;

        public void ApplyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }

        public void PrintState(string typeofVechicle)
        {
            Console.WriteLine(" Type of Vechicle : {2}, Speed : {0} and Gear : {1}", speed, gear, typeofVechicle);
        }

       
    }

    class Bike : IVechicle, IVechicleSpecific
    {
        int speed = 0;
        int gear = 0;

        public void ApplyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }

        public void PrintState(string typeofVechicle = "Bike")
        {
            Console.WriteLine("Type of Vechicle : {2}, Speed : {0} and Gear : {1}", speed, gear, typeofVechicle);
        }

        public void Accelerator()
        {

        }

        public void EngineType(string type)
        {
            throw new NotImplementedException();
        }

        public void WheelType(string wheelType)
        {
            throw new NotImplementedException();
        }
    }
}
