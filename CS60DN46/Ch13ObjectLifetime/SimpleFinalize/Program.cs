using System;

namespace SimpleFinalize {
	class Program {
		static void Main() {
			Console.WriteLine("***** Simple Finalize *****");
			Finalization();
			Console.ResetColor();
		}

		static void Finalization() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> finalizers");

			Console.WriteLine("Hit the return key to shut down this app");
			Console.WriteLine("and force the GC to invoke Finalize()");
			Console.WriteLine("for finalizable objects created in this AppDomain.");
			Console.ReadLine();
			MyResourceWrapper rw = new MyResourceWrapper();
		}
	}
}
