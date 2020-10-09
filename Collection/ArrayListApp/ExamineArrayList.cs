using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp {
	class ExamineArrayList {
		public void Start() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examining ArrayList (integer)");

			ArrayList list = new ArrayList();
			list.AddRange(new int[] {45,78,33,56,12,23,9});

			Console.WriteLine($"Capacity: {list.Capacity}");
			Console.WriteLine($"Count: {list.Count}");

			Console.Write("Content:");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			list.Sort();
			Console.Write("Sorted:");
			foreach (var i in list) Console.Write(" " + i);
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Examining ArrayList (string)");

			ArrayList lista = new ArrayList();
			lista.AddRange(new string[] { "Zhang","Wang","Li","Zhao","Liu" });

			Console.WriteLine($"Capacity: {lista.Capacity}");
			Console.WriteLine($"Count: {lista.Count}");

			Console.Write("Content:");
			foreach (var i in lista) Console.Write(" " + i);
			Console.WriteLine();

			lista.Sort();
			Console.Write("Sorted:");
			foreach (var i in lista) Console.Write(" " + i);
			Console.WriteLine();
		}
	}
}
