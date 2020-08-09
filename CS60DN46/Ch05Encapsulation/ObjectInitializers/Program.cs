using System;

namespace ObjectInitializers
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Object Init Syntax *****");
			NormalInit();
			CustomCtor();
			Console.ResetColor();
		}

		static void CustomCtor()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			new Point(PointColor.Blue) { X = 90, Y = 20 }.Display();
		}

		static void NormalInit()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			
			Point p1 = new Point(); p1.X = 10; p1.Y = 10; p1.Display();
			Point p2 = new Point(20, 20); p2.Display();
			Point p3 = new Point { X = 30, Y = 30 }; p3.Display();
			Point p5 = new Point { X = 50 }; p5.Display();
			new Point { Y = 60 }.Display();
			new Point(70, 70) { X = 80 }.Display();
		}
	}
}
