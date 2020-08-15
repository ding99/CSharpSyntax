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
			Deeping();
			Console.ResetColor();
		}

		static void Deeping()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Regarding internal reference value");

			Point p5 = new Point(100, 100, "Jane");
			Point p6 = (Point)p5.Clone();
			Console.WriteLine($"Before modification:");
			Console.WriteLine($"  p5 {p5}");
			Console.WriteLine($"  p6 {p6}");

			p6.desc.PetName = "New Point"; p6.X = 9;
			Console.WriteLine($"(Changed p6.desc.petName and p6.X)");
			Console.WriteLine($"After midification:");
			Console.WriteLine($"  p5 {p5}");
			Console.WriteLine($"  p6 {p6}");
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
	}
}
