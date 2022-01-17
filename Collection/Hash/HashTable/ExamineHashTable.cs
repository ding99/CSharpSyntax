using System;
using System.Collections;

namespace HashTable
{
    class ExamineHashTable {
		public void Start() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- HashTable with string key");

			Hashtable t1 = new Hashtable();
			t1.Add("001", "Zara Ali");
			t1.Add("002", "Abida Rehman");
			t1.Add("003", "Joe Holzner");
			t1.Add("004", "Mausam Benazir Nur");
			t1.Add("005", "M. Arif");

			string name = "Nuha Ali";
			if (t1.ContainsValue(name)) Console.WriteLine($"{name} is existing!");
			else t1.Add("006", name);

			ICollection vs = t1.Keys;
			Console.Write("Keys:");
			foreach (var v in vs) Console.Write(" " + v);
			Console.WriteLine();

			vs = t1.Values;
			Console.Write("Values:");
			foreach (var v in vs) Console.Write(" <" + v + ">");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- HashTable with integer key");

			Hashtable t2 = new Hashtable();
			t2.Add(1, "Zara Ali");
			t2.Add(2, "Abida Rehman");
			t2.Add(3, "Joe Holzner");
			t2.Add(4, "Mausam Benazir Nur");
			t2.Add(5, "M. Arif");

			if (t2.ContainsValue(name)) Console.WriteLine($"{name} is existing!");
			else t2.Add(6, name);

			vs = t2.Keys;
			Console.Write("Keys:");
			foreach (var v in vs) Console.Write(" " + v);
			Console.WriteLine();

			vs = t2.Values;
			Console.Write("Values:");
			foreach (var v in vs) Console.Write(" <" + v + ">");
			Console.WriteLine();
		}
	}
}
