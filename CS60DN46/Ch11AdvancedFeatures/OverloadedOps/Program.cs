using System;

namespace OverloadedOps {
	class Program {
		static void Main() {
			Console.WriteLine("***** Overloading Binary Operators");
			TwoPoints();
			Console.ResetColor();
		}

		static void TwoPoints() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Two Points");

			Point ptOne = new Point(100, 100), ptTwo = new Point(30, 30);
			Console.WriteLine($"ptOne = {ptOne}; ptTwo = {ptTwo}");

			Console.WriteLine($"phOne + ptTwo: {ptOne + ptTwo}");
			Console.WriteLine($"phOne + ptTwo: {ptOne - ptTwo}");
			Console.WriteLine($"phOne + 10: {ptOne + 10}");
			Console.WriteLine($"10 + phOne: {10 + ptOne}");
		}
	}
}
