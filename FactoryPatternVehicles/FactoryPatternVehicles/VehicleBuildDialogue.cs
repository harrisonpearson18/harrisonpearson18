using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternVehicles
{
    public class VehicleBuildDialogue
    {
        public static void VehicleStartupDialogue()
        {
            Console.WriteLine("Put key in ignition");
            Thread.Sleep(1000);
            Console.WriteLine("Turn Key");
            Thread.Sleep(1000);


        }
    }
}
