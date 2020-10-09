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

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Examine SortedSet with string");

			SortedSet<string> set3 = new SortedSet<string>();
			set3.Add("DDD");
			set3.Add("aaa");
			set3.Add("abcdef");
			set3.Add("AA");
			Console.Write("set3 Elements:");
			foreach (var v in set3) Console.Write(" " + v);
			Console.WriteLine();
		}

		public void ByList() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("-- SortedSet from List");
			List<string> list = new List<string>();
			list.AddRange(new string[] {"sam","perls","allen","perls" });

			Console.Write($"List Elements (size {list.Count}):");
			foreach (var v in list) Console.Write(" <" + v + ">");
			Console.WriteLine();

			SortedSet<string> set = new SortedSet<string>(list);
			Console.Write($"SortedSet Elements (size {set.Count}):");
			foreach (var v in set) Console.Write(" <" + v + ">");
			Console.WriteLine();
		}
	}
}

