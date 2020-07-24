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




			/////// 
			///
			string str = "Hello World";
			char x = str[4];
			Console.WriteLine(x);


			//////
			///

		}
	}





	public class God
	{
		public static Human[] Create() => new Human[] { new Man(), new Woman() };
	}

	public class Human { }
	public class Man : Human { }
	public class Woman : Human { }

	// keyword used while creating object.
	class Person
	{
		private string name;
		public Person(string name)
		{
			this.name = name;
		}
	}




	class Program2
	{
		class Clients
		{
			private string[] names = new string[10];
			public string this[int index]
			{
				get
				{
					return names[index];
				}
				set
				{
					names[index] = value;
				}
			}
		}
		static void Main(string[] args)
		{
			Clients c = new Clients();
			c[0] = "Dave";
			c[1] = "Bob";

			Console.WriteLine(c[1]);
		}
	}


	// INDEXER

	class Person3
	{
		private string name;
		public char this[int index]
		{
			get
			{
				return name[index];
			}
		}
	}




	class Box
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public Box(int h, int w)
		{
			Height = h;
			Width = w;
		}
		public static Box operator +(Box a, Box b)
		{
			int h = a.Height + b.Height;
			int w = a.Width + b.Width;
			Box res = new Box(h, w);
			return res;
		}
	}
	//static void Main2()
	//{
	//	Box b1 = new Box(14, 3);
	//	Box b2 = new Box(5, 7);
	//	Box b3 = b1 + b2;
	//
	//	Console.WriteLine(b3.Height);
	//	Console.WriteLine(b3.Width);
	//}




	abstract class Shape
	{
		public abstract void Draw();
	}
	class Circle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Circle Draw");
		}
	}
	class Rectangle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Rect Draw");
		}
	}
	//static void Main(string[] args)
	//{
	//	Shape c = new Circle();
	//	c.Draw();
	//Outputs "Circle Draw"
	//}

	public interface IShape
	{
		void Draw();
	}
	class Circle2 : IShape
	{
		public void Draw()
		{
			Console.WriteLine("Circle Draw");
		}
	}
	//	static void Main(string[] args)
	//	{
	//		IShape c = new Circle();
	///		c.Draw();
	//	//Outputs "Circle Draw"
	//	}


	struct Book
	{
		public string title;
		public double price;
		public string author;
	}


	//static void Main(string[] args)
	//{
	//	Book b;
	//	b.title = "Test";
	//	b.price = 5.99;
	//	b.author = "David";
	//
	//	Console.WriteLine(b.title);
	//Outputs "Test"
	//}



	struct Point
	{
		public int x;
		public int y;
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}
	//static void Main(string[] args)
	//{
	//	Point p = new Point(10, 15);
	//	Console.WriteLine(p.x);
	// Outputs 10
	//}


	//class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		SortedList<string, int> sl = new SortedList<string, int>();
	//
	//		sl.Add("Solo", 59);
	//		sl.Add("A", 95);
	//		sl.Add("Learn", 72);
	//		sl.Remove("A");
	//
	//		Console.WriteLine("Sorted List: ");
	//		foreach (string s in sl.Keys)
	//			Console.WriteLine(s + ": " + sl[s]);  // Learn: 72  Solo: 59
	//		Console.WriteLine("\nCount: " + sl.Count);  // 2
	//	}
	//}

}

