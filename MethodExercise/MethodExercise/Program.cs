using System;
using System.Runtime.CompilerServices;

namespace MethodExercise
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("First off, what is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your preferred color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite sport to watch?");
            string sport = Console.ReadLine();
            Console.WriteLine("What model of car do you like?");
            string car = Console.ReadLine();

            Console.WriteLine("Hey there, my name is " + (name) + " I am " + (age) + " years old and enjoy watching " + (sport) + " iny my free time.");
            Console.WriteLine(carBuilder(color, car));



        }

        public static string carBuilder(string color, string car)
        {

            Console.WriteLine("My favorite car to take joyrides in is a " + color + " " + car);
            return null;
        }


    }
}
