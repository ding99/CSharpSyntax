using System;

namespace SimpleDispose {
	class Program {
		static void Main() {
			Console.WriteLine("***** Dispose *****");
			UseDispose();
			UsingKeyword();
			MultiObjects();
			Console.ResetColor();
		}

		static void MultiObjects() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> multiple objects");

			using (MyResourceWrapper rw = new MyResourceWrapper(), rw2 = new MyResourceWrapper()) {
				//Use rw and rw2 objects
			}
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
