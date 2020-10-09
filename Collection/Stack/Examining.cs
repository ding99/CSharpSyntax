using System;
using System.Collections.Generic;

namespace Stack {
	class Examining {
		public void Start() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examine Stack");

			Stack<char> s = new Stack<char>();

			s.Push('A'); s.Push('M'); s.Push('G'); s.Push('M');
			Console.Write("Current Stack:");
			foreach (var c in s) Console.Write(" " + c);
			Console.WriteLine();

			s.Push('V'); s.Push('H');
			Console.WriteLine($"The next poppable value in stack: {s.Peek()}");
			Console.Write("Current Stack:");
			foreach (var c in s) Console.Write(" " + c);
			Console.WriteLine();

			Console.WriteLine("Removing 3 values");
			s.Pop(); s.Pop(); s.Pop();
			Console.Write("Current Stack:");
			foreach (var c in s) Console.Write(" " + c);
			Console.WriteLine();
		}
	}
}
