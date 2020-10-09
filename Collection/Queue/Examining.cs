using System;
using System.Collections.Generic;

namespace Queue {
	class Examining {
		public void Start() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examine Queue");

			Queue<char> q = new Queue<char>();

			q.Enqueue('A'); q.Enqueue('M'); q.Enqueue('G'); q.Enqueue('M');
			Console.Write("Current Stack:");
			foreach (var c in q) Console.Write(" " + c);
			Console.WriteLine();

			q.Enqueue('V'); q.Enqueue('H');
			Console.Write("Current Stack:");
			foreach (var c in q) Console.Write(" " + c);
			Console.WriteLine();

			Console.WriteLine("Removing some values");
			char ch = (char)q.Dequeue();
			Console.WriteLine($"The removed value {ch}");
			ch = (char)q.Dequeue();
			Console.WriteLine($"The removed value {ch}");

			Console.Write("Current Stack:");
			foreach (var c in q) Console.Write(" " + c);
			Console.WriteLine();
		}
	}
}
