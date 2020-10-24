using System;
using System.Threading;

namespace ExamineThreadPool {
	class Program {
		static void Main() {
			Console.WriteLine("***** CLR Thread Pool *****");
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine($"Main thread  ({Thread.CurrentThread.ManagedThreadId}) started");

			Printer p = new Printer();

			WaitCallback workItem = new WaitCallback(PrintTheNumbers);

			for (int i = 0; i < 10; i++)
				ThreadPool.QueueUserWorkItem(workItem, p);
			Console.WriteLine("All tasks queued");

			Console.ReadLine();
			Console.ResetColor();
		}

		static void PrintTheNumbers(object state) {
			Printer task = (Printer)state;
			task.PrintNumbers();
		}
	}
}
