﻿using System;

namespace OverloadedOps {
	class Program {
		static void Main() {
			Console.WriteLine("***** Overloading Binary Operators");
			TwoPoints();
			ShortHandAssign();
			Console.ResetColor();
		}

		static void ShortHandAssign() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Shorthand assignment operators");

			Point ptOne = new Point(100, 100), ptTwo = new Point(30, 30);
			Point ptThree = new Point(90,5), ptFour = new Point(0, 500);
			Console.WriteLine($"ptOne = {ptOne}; ptTwo = {ptTwo}");
			Console.WriteLine($"ptThree = {ptThree}; ptFour = {ptFour}");

			Console.WriteLine($"phThree += ptTwo: {ptThree += ptTwo}");
			Console.WriteLine($"phFour -= ptThree: {ptFour -= ptThree}");
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
