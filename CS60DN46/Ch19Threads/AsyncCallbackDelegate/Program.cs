﻿using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace AsyncCallbackDelegate {
	public delegate int BinaryOp(int x, int y);

	class Program {
		private static bool isDone = false;

		static void Main() {
			Console.WriteLine("***** Examine AsyncCallback Delegate *****");
			UseCallback();
			Console.ResetColor();
		}

		private static void UseCallback() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Use Async Callback Delegate");

			Console.WriteLine($"Primary invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");

			int x = 10, y = 20;
			BinaryOp b = new BinaryOp(Add);
			IAsyncResult result = b.BeginInvoke(x, y, new AsyncCallback(AddComplete), "Primary thanks you for adding these numbers");

			while (!isDone) {
				Thread.Sleep(1000);
				Console.WriteLine("Working...");
			}
		}

		static int Add(int x, int y) {
			Console.WriteLine($"Add({x},{y}) invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");
			Thread.Sleep(3000);
			return x + y;
		}

		static void AddComplete(IAsyncResult result) {
			Console.WriteLine($"AddComplete() invoked on thread <{Thread.CurrentThread.ManagedThreadId}>");
			Console.WriteLine("Your addition is complete");

			AsyncResult ar = (AsyncResult)result;
			BinaryOp b = (BinaryOp)ar.AsyncDelegate;
			string msg = (string)ar.AsyncState;
			Console.WriteLine($"The result is {b.EndInvoke(result)}");
			Console.WriteLine($"Message from the primary thread: <{msg}>");

			isDone = true;
		}
	}
}
