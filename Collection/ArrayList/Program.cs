using System;

namespace ArrayListApp {
	class Program {
		static void Main() {
			Console.WriteLine("== Start");

			ExamineArrayList compare = new ExamineArrayList();
			compare.SameType();
			compare.SelfComparer();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
