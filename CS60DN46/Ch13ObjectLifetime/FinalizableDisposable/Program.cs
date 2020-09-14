using System;

namespace FinalizableDisposable {
	class Program {
		static void Main() {
			Console.WriteLine("***** Finalizable and Disposable Class *****");
			Combo();
			Console.ResetColor();
		}

		static void Combo() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Dispose() / Destructor Combo Platter");

			MyResourceWrapper rw = new MyResourceWrapper();
			rw.Dispose();

			MyResourceWrapper rw2 = new MyResourceWrapper();
		}
	}
}
