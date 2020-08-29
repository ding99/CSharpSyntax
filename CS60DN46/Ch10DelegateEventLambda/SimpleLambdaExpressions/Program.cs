using System;
using System.Collections.Generic;

namespace SimpleLambdaExpressions {
	class Program {
		static void Main() {
			Console.WriteLine("***** Lambdas *****");
			TraditionalDelegateSyntax();
			AnonymousMethodSyntax();
			LambdaExpressionSyntax();
			Console.ResetColor();
		}

		static void LambdaExpressionSyntax() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Lambda Expression Syntax");

			List<int> list = new List<int>();
			list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
			Console.Write("Here are original numbers :");
			foreach (int e in list) Console.Write($" {e}");
			Console.WriteLine();

			List<int> evens = list.FindAll(i => (i % 2) == 0);

			Console.Write("Here are your even numbers:");
			foreach (int e in evens) Console.Write($" {e}");
			Console.WriteLine();
		}

		static void AnonymousMethodSyntax() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Anonymous Method Syntax");

			List<int> list = new List<int>();
			list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
			Console.Write("Here are original numbers :");
			foreach (int e in list) Console.Write($" {e}");
			Console.WriteLine();

			List<int> evens = list.FindAll(delegate(int i) { return (i % 2) == 0; });

			Console.Write("Here are your even numbers:");
			foreach (int e in evens) Console.Write($" {e}");
			Console.WriteLine();
		}

		static void TraditionalDelegateSyntax() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Traditional Delegate Syntax");

			List<int> list = new List<int>();
			list.AddRange(new int[] {20,1,4,8,9,44});
			Console.Write("Here are original numbers :");
			foreach (int e in list) Console.Write($" {e}");
			Console.WriteLine();

			Predicate<int> callback = IsEvenNumber;
			List<int> evens = list.FindAll(callback);

			Console.Write("Here are your even numbers:");
			foreach (int e in evens) Console.Write($" {e}");
			Console.WriteLine();
		}

		static bool IsEvenNumber(int i) { return (i % 2) == 0; }
	}
}
