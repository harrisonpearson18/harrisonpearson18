using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carNames = { "Mustang", "Corvette", "Ford", "GMC" };


            var carSpaces = from car in carNames
                            where car.Contains("r")
                            orderby car ascending
                            select car;

            foreach (var car in carSpaces)
            {
                Console.WriteLine(car);
            }

            var games = new List<String> { "COD", "Valorant", "Dead by Daylight" };
            IEnumerable<string> gameNameLength = games.OrderByDescending(x => x.Length);

            foreach(var i in gameNameLength)
            {
                Console.WriteLine(i);
            }
        }
    }
}
