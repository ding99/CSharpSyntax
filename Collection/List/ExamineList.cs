using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List {
	class ExamineList {
		public void Sort() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examine List");

			int[] ints = { 10, 4, 2, 33, 93 };
			Console.Write("Orig:");
			foreach (var i in ints) Console.Write(" " + i);
			Console.WriteLine();

			Array.Sort<int>(ints);
			Console.Write("Sorted:");
			foreach (var i in ints) Console.Write(" " + i);
			Console.WriteLine();
		}
	}
}
