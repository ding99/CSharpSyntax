using System;

namespace ObjectInitializers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Object Init Syntax *****");
			Manually();
			Console.ResetColor();
		}

		static void Manually()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			
			Point p1 = new Point();
			p1.X = 10;
			p1.Y = 10;
			p1.Display();

			Point p2 = new Point(20, 20);
			p2.Display();

			Point p3 = new Point { X = 30, Y = 30 };
			p3.Display();
		}
	}
}
