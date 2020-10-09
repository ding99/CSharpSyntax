using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HashTable {
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

			ICollection keys = t1.Keys;
			foreach (var key in keys) Console.Write(" " + key);
			Console.WriteLine();
		}
	}
}
