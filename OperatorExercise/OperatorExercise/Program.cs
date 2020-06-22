using System;
using System.Net;

namespace OperatorExercise
{
    class ProgramOperatorExercise
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Please enter the value of A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of B:");
            int b = int.Parse(Console.ReadLine());
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine((a) + "/" + (b) + " is " + (quotient) + " remainder " + (remainder));

            // Exercise 2

            Console.WriteLine("What is the radius of your circle?");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of a circle with the radius of " + r + " is " + AreaOfCircle(r));
        }

        static double AreaOfCircle(double r)
        {

            double area = Math.PI * (r * r);

            return area;
        }


    }
}
