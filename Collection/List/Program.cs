using System;

namespace List {
	class Program {
		static void Main() {
			Console.WriteLine("== Start");
			ExamineList examer = new ExamineList();
			examer.Sort();

			First f = new First();
			f.Start();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
