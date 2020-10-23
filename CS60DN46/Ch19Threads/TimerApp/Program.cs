using System;
using System.Threading;

namespace TimerApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Working with Timer Type *****");
			Console.ForegroundColor = ConsoleColor.Yellow;

			//create the delegate for the timer type
			TimerCallback timeCB = new TimerCallback(PrintTime);

			Timer t = new Timer(timeCB, null, 0, 1000);

			Console.WriteLine("Hit key to terminate...");
			Console.ReadLine();

			Console.ResetColor();
		}

		static void PrintTime(object state) {
			Console.WriteLine($"Time is: {DateTime.Now.ToLongTimeString()}");
		}
	}
}
