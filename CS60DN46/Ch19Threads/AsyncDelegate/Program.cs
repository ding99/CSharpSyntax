using System;
using System.Threading;

namespace AsyncDelegate {
	public delegate int BinaryOp(int x, int y);

	class Program {
		static void Main() {
			Console.WriteLine("***** Async Delegate Invocation *****");
			AsyncDelegate();
			Console.ResetColor();
		}

		private static void AsyncDelegate() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Primary invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");

			int x = 10, y = 20;
			BinaryOp b = new BinaryOp(Add);
			IAsyncResult result = b.BeginInvoke(x, y, null, null);

			Console.WriteLine($"Doing more work in Primary <{Thread.CurrentThread.ManagedThreadId}>");

			int answer = b.EndInvoke(result);
			Console.WriteLine($"{x} + {y} is {answer}");
		}

		static int Add(int x, int y) {
			Console.WriteLine($"Add() invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");
			Thread.Sleep(2000);
			return x + y;
		}
	}
}
