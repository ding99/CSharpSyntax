using System;
using System.Collections;

namespace ArrayListApp {

	class MyComparer : IComparer {
		public int Compare(object x, object y) {
			if(x is int) {
				if(y is int)
					return (int)x < (int)y ? 1 : (int)x == (int)y ? 0 : -1;
				return -1;
			}
			return y is int ? 1 : 0;
		}
	}

	class ExamineArrayList {
		public void SameType() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("-- Examining ArrayList (integer)");

			ArrayList list = new ArrayList();
			list.AddRange(new int[] {45,78,33,56,12,23,9});

			Console.WriteLine($"Capacity: {list.Capacity}, Count: {list.Count}");
			Console.Write("Content :");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			list.Sort();
			Console.Write("Sorted  :");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			Console.WriteLine("< Self comparer >");
			list.Sort(new MyComparer());
			Console.Write("Sorted  :");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Examining ArrayList (string)");

			ArrayList lista = new ArrayList();
			lista.AddRange(new string[] { "Zhang","Wang","Li","Zhao","Liu" });

			Console.WriteLine($"Capacity: {lista.Capacity}, Count: {lista.Count}");
			Console.Write("Content :");
			foreach (var i in lista) Console.Write(" " + i);
			Console.WriteLine();

			lista.Sort();
			Console.Write("Sorted  :");
			foreach (var i in lista) Console.Write(" " + i);
			Console.WriteLine();
		}
		public void SelfComparer() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examining ArrayList (integer)");

			ArrayList list = new ArrayList();
			list.AddRange(new int[] { 45, 78, 33, 56, 12, 23, 9 });

			Console.WriteLine($"Capacity: {list.Capacity}, Count: {list.Count}");
			Console.Write("Content :");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			list.Add("efg");
			list.Add(55);

			Console.WriteLine($"Capacity: {list.Capacity}, Count: {list.Count}");
			Console.Write("Content :");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("< Self comparer >");
			list.Sort(new MyComparer());
			Console.Write("Sorted  :");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("<Insert 1 at position 2, and \"abc\" at position 2>");
			list.Insert(2, 1);
			list.Insert(2, "abc");

			Console.WriteLine($"Capacity: {list.Capacity}, Count: {list.Count}");
			Console.Write("Content :");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("< Self comparer >");
			list.Sort(new MyComparer());
			Console.Write("Sorted  :");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();
		}
	}
}
