using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicles
{
    class Trike : IVehicle
    {

        public Trike()
        {

        }

        public void drive()
        {
            VehicleBuildDialogue.VehicleStartupDialogue();
            Console.WriteLine("The trike is driving.");

        }
    }
}
