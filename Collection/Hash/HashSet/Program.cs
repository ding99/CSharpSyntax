using System;

namespace HashSet {
	class Program {
		static void Main() {
			Console.WriteLine("== Start HashSet Examination");

			ExamineHashSet exam = new ExamineHashSet();
			exam.Start();

			Console.ResetColor ();
			Console.WriteLine ("== End");
		}
	}
}
