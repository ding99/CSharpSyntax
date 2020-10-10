using System;

namespace EAAssess {
	class Program {
		static void Main() {
			Console.WriteLine("== Start");

			Question1 exam1 = new Question1();
			exam1.Start();

			Question2 exam2 = new Question2();
			exam2.Start();

			Question3 exam3 = new Question3();
			exam3.Start();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
