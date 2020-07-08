using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternVehicles
{
    static class CarBuilder
    {

        public static IVehicle GetCar(int wheelCount)
        {
            switch (wheelCount)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Trike();
                case 4:
                    return new Truck();
                default:
                    return new Truck();
            }
        }

    }
}
