using System;

namespace OverloadedOps {
	class Program {
		static void Main() {
			Console.WriteLine("***** Overloading Binary Operators");
			TwoPoints();
			ShortHandAssign();
			Unary();
			OverrideEquals();
			Comparison();
			Console.ResetColor();
		}

		static void Comparison() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Overloading Comparison Operators");

			Point ptOne = new Point(100, 100), ptTwo = new Point(30, 30);
			Console.WriteLine($"ptOne = {ptOne}; ptTwo = {ptTwo}");
			Console.WriteLine($"ptOne < ptTwo: {ptOne < ptTwo}; ptOne > ptTwo: {ptOne > ptTwo}");
		}

		static void OverrideEquals() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Overloading Equality Operators"); ;

			Point ptOne = new Point(100, 100), ptTwo = new Point(30, 30);
			Console.WriteLine($"ptOne = {ptOne}; ptTwo = {ptTwo}");
			Console.WriteLine($"ptOne == ptTwo: {ptOne == ptTwo}; ptOne != ptTwo : {ptOne != ptTwo}");
		}

		static void Unary() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Overloading Unary Operators");

			Point ptFive = new Point(1, 1);
			Console.WriteLine($"ptFive {ptFive}; ++ptFive = {++ptFive}, --ptFive = {--ptFive}; ptFive {ptFive}");

			Point ptSix = new Point(20, 20);
			Console.WriteLine($"ptSix {ptSix}; ptSix++ = {ptSix++}, ptSix-- = {ptSix--}; ptSix: {ptSix}");
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
