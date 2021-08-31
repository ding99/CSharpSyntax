using System;

namespace Parsings {
	class Program {
		static void Main() {
			Console.WriteLine("== Parsing Start");

			new Partial().Start();

			Console.ResetColor();
			Console.WriteLine("== Parsing End");
		}
	}
}
