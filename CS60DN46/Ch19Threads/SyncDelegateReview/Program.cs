using System;
using System.Threading;

namespace SyncDelegateReview {
	public delegate int BinaryOp(int x, int y);

	class Program {
		static void Main() {
			Console.WriteLine("***** .NET Delegate Review *****");
			SynchDelegate();
			Console.ResetColor();
		}

		private static void SynchDelegate() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Synch Delegate Review");

			Console.WriteLine($"Primary invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");

			BinaryOp b = new BinaryOp(Add);
			int x = 10, y = 20;
			int answer = b(x, y);

			Console.WriteLine("Doing more work in primary thread");
			Console.WriteLine($"{x} + {y} is {answer}");
		}

		static int Add(int x, int y) {
			Console.WriteLine($"Add() invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");
			Thread.Sleep(2000);
			return x + y;
		}
	}
}
