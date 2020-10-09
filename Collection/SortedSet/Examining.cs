using System;
using System.Collections.Generic;

namespace SortedSet {
	class Examining {
		public void Start() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examine SortedSet with integer");

			SortedSet<int> set1 = new SortedSet<int>();
			set1.Add(101);
			set1.Add(10001);
			set1.Add(1001);
			set1.Add(100001);
			Console.Write("set1 Elements:");
			foreach (var v in set1) Console.Write(" " + v);
			Console.WriteLine();

			SortedSet<int> set2 = new SortedSet<int> { 2002, 200002, 20002, 202 };
			Console.Write("set2 Elements:");
			foreach (var v in set2) Console.Write(" " + v);
			Console.WriteLine();

			if (set1.Contains(1001)) Console.WriteLine("set1 contains 1001");
			if (!set2.Contains(1001)) Console.WriteLine("set2 does not contain 1001");
		}
	}
}
