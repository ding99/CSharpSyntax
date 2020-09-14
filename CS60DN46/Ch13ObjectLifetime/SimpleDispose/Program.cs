using System;

namespace SimpleDispose {
	class Program {
		static void Main() {
			Console.WriteLine("***** Dispose *****");
			UseDispose();
			UsingKeyword();
			Console.ResetColor();
		}

		static void UsingKeyword() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> using keyword");

			using (MyResourceWrapper rw = new MyResourceWrapper()) {
				//Use rw object
			}
		}

		static void UseDispose() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Disposable");

			MyResourceWrapper rw = new MyResourceWrapper();
			if(rw is IDisposable) rw.Dispose();
		}
	}
}
