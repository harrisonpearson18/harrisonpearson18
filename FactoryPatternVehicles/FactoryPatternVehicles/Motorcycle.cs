using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicles
{
    class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }

        public void drive()
        {
            VehicleBuildDialogue.VehicleStartupDialogue();
            Console.WriteLine("The motorcycle is driving.");

        }
    }
}
