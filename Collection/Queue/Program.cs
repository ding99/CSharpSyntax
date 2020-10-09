using System;

namespace Queue {
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
