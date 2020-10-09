using System;

namespace SortedList {
	class Program {
		static void Main() {
			Console.WriteLine("== Start");
			ExamineSortedList exam = new ExamineSortedList();
			exam.Start();
			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
