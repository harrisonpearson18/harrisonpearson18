using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicles
{
    public class Truck : IVehicle
    {
        public Truck()
        {

        }

        public void drive()
        {
            VehicleBuildDialogue.VehicleStartupDialogue();
            Console.WriteLine("The truck is driving.");
        }


    }
}
