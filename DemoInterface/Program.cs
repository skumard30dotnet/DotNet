using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            BiCycleWithGear biCycle = new BiCycleWithGear();
            biCycle.ChangeGear(2);
            biCycle.SpeedUp(50);
            biCycle.ApplyBrakes(25);
            biCycle.PrintState("BiCycle");

            Bike bike = new Bike();
            bike.ChangeGear(4);
            bike.SpeedUp(80);
            bike.ApplyBrakes(40);
            bike.PrintState();

            IVechicle vechicle = new Bike();
            vechicle.SpeedUp(50);
            vechicle.ApplyBrakes(20);
            vechicle.ChangeGear(2);

            Bike b = new Bike();
            b.PrintState();

            Console.Read();
        }
    }
}
