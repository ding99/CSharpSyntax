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

			Console.WriteLine($"Invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");

			BinaryOp b = new BinaryOp(Add);
			int answer = b(10, 20);

			Console.WriteLine("Doing more work in Primary");
			Console.WriteLine($"10 + 10 is {answer}");
		}

		static int Add(int x, int y) {
			Console.WriteLine($"Add() invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");
			Thread.Sleep(3000);
			return x + y;
		}
	}
}
