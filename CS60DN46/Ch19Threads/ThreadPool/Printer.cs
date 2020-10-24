using System;
using System.Threading;

namespace ExamineThreadPool {
	class Printer {
		private int n = 0;

		public void PrintNumbers() {
			Console.Write($"\nStart({Thread.CurrentThread.ManagedThreadId})");
			for (int i = 0; i < 10; i++) {
				Thread.Sleep(1000 * new Random().Next(2));
				Console.Write($" {i}({Thread.CurrentThread.ManagedThreadId}){n++}");
			}
			Console.WriteLine($" End({Thread.CurrentThread.ManagedThreadId})");
		}

	}
}
