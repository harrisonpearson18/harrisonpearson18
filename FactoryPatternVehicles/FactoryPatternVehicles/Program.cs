using System;
using System.Dynamic;

namespace FactoryPatternVehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelcount;
            bool input = false;
            do
            {
                Console.WriteLine("How many wheels does your vehicle have?");
                Console.WriteLine("Options: 2, 3, 4");

                input = int.TryParse(Console.ReadLine(), out wheelcount);
            } while (input == false);

            var vehicle = CarBuilder.GetCar(wheelcount);
            vehicle.drive();
        }
    }
}
