using System;

namespace SelectionStatements
{
    class Program
    {
        private const string V = "Math";

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

            subjectSwitch();
            subjectSwitch();
        }
        static void subjectSwitch()
        {
            Console.WriteLine("Input your favorite school subject from the list below.");
            Console.WriteLine("Subjects to choose from: Math, Science, History, English, or Spanish");
            string userSubject = Console.ReadLine().ToLower();
        switch (userSubject)
            {
                case "math":
                    Console.WriteLine("Math is a lot of fun");
                    break;
                case "science":
                    Console.WriteLine("Lots can be learned from science");
                    break;
                case "history":
                    Console.WriteLine("Knowing the past is important for the future");
                    break;
                case "english":
                    Console.WriteLine("English is a hard language");
                    break;
                case "spanish":
                    Console.WriteLine("Como estas?");
                    break;
                case null:
                    Console.WriteLine("School is fun!");
                    break;
            }
        }
    }
}
