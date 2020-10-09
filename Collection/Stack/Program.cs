using System;

namespace Stack {
	class Program {
		static void Main() {
			Console.WriteLine("== Start");
			Examining exam = new Examining();
			exam.Start();
			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
