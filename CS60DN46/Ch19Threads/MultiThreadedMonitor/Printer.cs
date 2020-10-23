using System;
using System.Threading;

namespace MultiThreadedMonitor {
	class Printer {
		private object threadLock = new object();
		private int n = 0;
		//lock statement is a shorthand notation ofr working with the System.Threading.Monitor class

		public void PrintNumbers() {
			Monitor.Enter(threadLock);

			try {
				Console.Write($"\nStart-{Thread.CurrentThread.Name}:");
				for (int i = 0; i < 10; i++) {
					Random r = new Random();
					Thread.Sleep(1000 * r.Next(3));
					Console.Write($" {Thread.CurrentThread.Name}({i}){n++}");
				}
				Console.WriteLine($" End-{Thread.CurrentThread.Name}.");
			}
			finally { Monitor.Exit(threadLock); }
		}
	}
}
