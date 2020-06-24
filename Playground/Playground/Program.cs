using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayGround
{
	class Program
	{
		public static void Main(string[] args)
		{
			int answer;
			string response;
			Console.WriteLine("Enter a number:");
			answer = int.Parse(Console.ReadLine());
			if (answer < 9)
			{
				response = answer + " is less than nine";
				Console.WriteLine(response);
			}
			else
			{
				response = answer + " is greater than or equal to nine";
				Console.WriteLine(response);
			}

			Console.WriteLine("Enter a second number:");
			var answer2 = int.Parse(Console.ReadLine());
			var response2 = (answer2 < 9) ? $"{answer2} is less than nine" : $"{answer2} is greater than or equal to nine";
			Console.WriteLine(response2);
		}
	}
}
