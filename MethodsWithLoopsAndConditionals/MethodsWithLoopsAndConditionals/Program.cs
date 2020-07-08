using System;
using System.Dynamic;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            numPrinter();
            triNumPrinter();

            Console.WriteLine("Enter a value for int a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value for int b:");
            int b = int.Parse(Console.ReadLine());
            numChecker(a, b);

            Console.WriteLine("Enter a random number:");
            int c = int.Parse(Console.ReadLine());
            evenOrOdd(c);

            Console.WriteLine("Enter a positive or negative number:");
            int e = int.Parse(Console.ReadLine());
            positiveOrNegative(e);

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            ageReader(age);

            Console.WriteLine("Enter a value between -10 and 10:");
            int userInput = int.Parse(Console.ReadLine());
            intChecker(userInput);

            Console.WriteLine("Enter an integer to multiply:");
            int myInt = int.Parse(Console.ReadLine());
            multiplyInt(myInt);

            Console.WriteLine("Enter the desired length of a new array:");
            int number = int.Parse(Console.ReadLine());
            indexArray(number);

            Console.WriteLine("Enter the desired length of a new array to find the sum of:");
            int number2 = int.Parse(Console.ReadLine());
            sumArray(number2);

            Console.WriteLine("Enter a number to cube");
            int cube = int.Parse(Console.ReadLine());
            cubePower(cube);


            Console.WriteLine("Thanks for running me :D");
        }

        static void numPrinter()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void triNumPrinter()
        {
            int i = 3;
            do
            {
                Console.WriteLine(i);
                i += 3;
            } while (i <= 999);
        }

        static void numChecker(int a, int b)
        {
            var response = (a == b) ? $"{a} is equal to {b}" : $"{a} is not equal to {b}";
            Console.WriteLine(response);
        }

        static void evenOrOdd(int c)
        {
            int d = c % 2; 
            if (d == 0)
            {
                Console.WriteLine($"{c} is an even number.");
            }
            else
            {
                Console.WriteLine($"{c} is an odd number.");
            }
        }

        static void positiveOrNegative(int e)
        {
            int f = e / 1;
            var response2 = (f > 1) ? $"{e} is a positive number" : $"{e} is a negative number";
            Console.WriteLine(response2);
        }

        static void ageReader(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are too young to vote!");
            }
        }

        static void intChecker(int userInput)
        {
            var response3 = (userInput >= -10 && userInput <= 10) ? $"{userInput} is equal to or in between -10 and 10" : $"{userInput} is not between -10 and 10";
            Console.WriteLine(response3);
        }

        static void multiplyInt(int myInt)
        {
            int p = 1;
            do
            {
                int temp = myInt * p;
                Console.WriteLine(temp);
                p++;
            } while (p < 13);
        }

        static void indexArray(int number)
        {
            var r = new Random();
            int[] arr = new int[number];
            int placeholder = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                arr[placeholder] = randomFill();
                placeholder++;
                }

            Console.WriteLine("Random array below..");

            foreach(var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static int randomFill()
        {
            Random rand = new Random();
            int randomNum = rand.Next(1,100);
            return randomNum;
        }

        static void sumArray(int number2)
        {
            int sum = 0;
            int[] arr = new int[number2];
            int placeholder = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[placeholder] = randomFill();
                placeholder++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Adding the values of the array below to find the sum..");
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(sum);
        }

        static void cubePower(int cube)
        {

            int cubed = cube * cube * cube;
            Console.WriteLine($"{cube} cubed is {cubed}");
        }
    }
}
