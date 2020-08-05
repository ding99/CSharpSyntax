using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructs
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Structs *****");

			FirstLook();

			Console.ResetColor();
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
			public void Increment() { X++; Y++; }
			public void Decrement() { X--; Y--; }
			public void Display() { Console.WriteLine($"X = {X}, Y = {Y}"); }
		}
	}
}
