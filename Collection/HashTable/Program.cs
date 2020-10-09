using System;

namespace HashTable {
	class Program {
		static void Main() {
			Console.WriteLine("== Start");
			ExamineHashTable exam = new ExamineHashTable();
			exam.Start();
			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
