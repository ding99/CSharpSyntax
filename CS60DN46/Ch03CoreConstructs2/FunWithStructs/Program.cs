using System;
using System.Data.SqlClient;

namespace FunWithStructs
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Structs *****");

			FirstLook();
			ValueTypeAssignment();
			ReferenceTypeAssignment();

			Console.ResetColor();
		}

		static void ReferenceTypeAssignment()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Assigning reference types");

			PointRef p1 = new PointRef(10, 10);
			PointRef p2 = p1;

			p1.Display(); p2.Display();
			p1.X = 100; Console.WriteLine("-> Changed p1.X");
			p1.Display(); p2.Display();
		}


		static void ValueTypeAssignment()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Assigning value types");

			Point p1 = new Point(10, 10);
			Point P2 = p1;

			p1.Display(); P2.Display();

			p1.X = 100;
			Console.WriteLine("-> Changed p1.X");
			p1.Display(); P2.Display();
		}

		static void FirstLook()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Point myPoint; myPoint.X = 349; myPoint.Y = 76; myPoint.Display();
			myPoint.Increment(); myPoint.Display();

			Point p1 = new Point(); p1.Display();
		}

		struct Point
		{
			public int X, Y;
			public Point(int XPos, int Ypos) { X = XPos; Y = Ypos; }
			public void Increment() { X++; Y++; }
			public void Decrement() { X--; Y--; }
			public void Display() { Console.WriteLine($"X = {X}, Y = {Y}"); }
		}

		class PointRef
		{
			public int X, Y;
			public PointRef(int XPos, int YPos) { X = XPos; Y = YPos; }
			public void Increment() { X++; Y++; }
			public void Decrement() { X--; Y--; }
			public void Display() { Console.WriteLine($"X = {X}, Y = {Y}"); }
		}
	}
}
