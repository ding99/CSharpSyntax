using System;

namespace Enumarable {
	class Program {
		static void Main() {

			Console.WriteLine("== Start");

			Existence e = new Existence();
			e.ExistAny();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}
