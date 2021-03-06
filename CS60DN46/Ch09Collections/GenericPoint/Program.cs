﻿using System;

namespace GenericPoint
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Custom Generic Structures and Classes *****");
			PracticeStruct();
			Console.ResetColor();
		}

		static void PracticeStruct()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> invoke custom generic struct");

			Point<int> p = new Point<int>(10, 20);
			Console.WriteLine($"int type: <{p}>");
			p.ResetPoint();
			Console.WriteLine($"int type (reset): <{p}>");

			Point<double> p2 = new Point<double>(5.3, 7.88);
			Console.WriteLine($"double type: <{p2}>");
			p2.ResetPoint();
			Console.WriteLine($"double type (reset): <{p2}>");

			Point<string> p3 = new Point<string>("x-value", "y-value");
			Console.WriteLine($"string type: <{p3}>");
			p3.ResetPoint();
			Console.WriteLine($"string type (reset): <{p3}>");

			Console.WriteLine("-> use properties");
			Point2<double> p5 = new Point2<double>(3.3, 6.61);
			Console.WriteLine($"double type: <{p5}>");
			p5.ResetPoint();
			Console.WriteLine($"double type (reset): <{p5}>");
		}
	}
}
