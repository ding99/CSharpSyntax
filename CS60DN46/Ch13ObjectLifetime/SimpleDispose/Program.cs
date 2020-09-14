using System;

namespace SimpleDispose {
	class Program {
		static void Main() {
			Console.WriteLine("***** Dispose *****");
			UseDispose();
			Console.ResetColor();
		}

		static void UseDispose() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			MyResourceWrapper rw = new MyResourceWrapper();
			rw.Dispose();
		}
	}
}
