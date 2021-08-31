using System;

namespace Parsings {
	class Program {
		static void Main() {
			Console.WriteLine("== Parsing Start");

			new Partial().Start();
			new String2Uint().Start();

			Console.ResetColor();
			Console.WriteLine("== Parsing End");
		}
	}
}
