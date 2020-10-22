using System;
using System.Threading;

namespace AutoResetEvent {
	class Program {
		private static System.Threading.AutoResetEvent waitHandle = new System.Threading.AutoResetEvent(false);

		static void Main() {
			Console.WriteLine("***** Use AutoResetEvent *****");
			Console.ForegroundColor = ConsoleColor.Cyan;

			Console.WriteLine($"ID of thread in Main(): {Thread.CurrentThread.ManagedThreadId}");

			AddParams ap = new AddParams(10, 20);
			Thread t = new Thread(new ParameterizedThreadStart(Add));
			t.Start(ap);

			waitHandle.WaitOne();
			Console.WriteLine("Other thread is done!");

			Console.ResetColor();
		}

		static void Add(object data) {
			if(data is AddParams) {
				Console.WriteLine($"ID of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");

				AddParams ap = (AddParams)data;
				Console.WriteLine($"{ap.a} + {ap.b} is {ap.a + ap.b}");

				waitHandle.Set();
			}
		}
	}
}
