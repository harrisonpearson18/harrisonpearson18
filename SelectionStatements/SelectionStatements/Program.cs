using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 100);
            Console.WriteLine($"Guess the correct number between 1 and 100");
            var userInput = int.Parse(Console.ReadLine());
            
            if (userInput < favNumber)
            {
                Console.WriteLine($"Too low");
            }

            else if(userInput > favNumber)
            {
                Console.WriteLine($"Too high");
            }

            else
            {
                Console.WriteLine($"Nevermind");
            }

            Console.WriteLine($"The correct number was {favNumber}");
        }
    }
}
