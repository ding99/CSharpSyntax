using System;
using System.Threading;

namespace AddWithThreads {
	class Program {
		static void Main() {
			Console.WriteLine("***** Working with the ParameterizedThreadStart Delegate *****");
			UseParameterizedThreadStart();
			Console.ResetColor();
		}

		private static void UseParameterizedThreadStart() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Adding with Thread objects");
			Console.WriteLine($"ID of thread in Primary: {Thread.CurrentThread.ManagedThreadId}");

			AddParams ap = new AddParams(10, 20);
			Thread t = new Thread(new ParameterizedThreadStart(Add));
			t.Start(ap);

			ap = new AddParams(300, 500);
			t = new Thread(new ParameterizedThreadStart(Add));
			t.Start(ap);

			Thread.Sleep(5000);
		}

		private static void Add(object data) {
			if(data is AddParams) {
				Console.WriteLine($"ID of thread in Add(): {Thread.CurrentThread.ManagedThreadId}");

				AddParams ap = (AddParams)data;
				Console.WriteLine($"{ap.a} + {ap.b} is {ap.a + ap.b}");
			}
		}
	}
}
