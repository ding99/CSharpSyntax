using System;

namespace CloneablePoint
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Object Cloning *****");
			Referencs();
			Cloning();
			Console.ResetColor();
		}

		static void Referencs()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> reference value assignment");

			Point p1 = new Point(50, 50);
			Point p2 = p1;
			p2.X = 20;
			Console.WriteLine($"P1: {p1}");
			Console.WriteLine($"P2: {p2}");
		}

		static void Cloning()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Cloning reference value");

			Point p3 = new Point(100, 100);
			Point p4 = (Point)p3.Clone();

			p4.X = 30;
			Console.WriteLine($"P3: {p3}");
			Console.WriteLine($"P4: {p4}");

			Point2 p3_2 = new Point2(200, 200);
			Point2 p4_2 = (Point2)p3_2.Clone();

			p4_2.X = 60;
			Console.WriteLine($"P3_2: {p3_2}");
			Console.WriteLine($"P4_2: {p4_2}");
		}
	}
}
