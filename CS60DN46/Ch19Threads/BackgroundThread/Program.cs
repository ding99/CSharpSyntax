using System;
using System.Threading;

namespace BackgroundThread {
	class Program {
		static void Main() {
			Console.WriteLine("***** Foreground Thread and Background Thread *****");

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Background(Daemon) Thread");
			Thread.CurrentThread.Name = "MainThread";

			Printer p = new Printer();
			Thread bg = new Thread(new ThreadStart(p.PrintNumbers));
			bg.Name = "SecondaryThread";
			
			//each number will be printed if comment out the line
			bg.IsBackground = true;
			
			bg.Start();

			Thread.Sleep(1500);
			Console.ResetColor();
		}
	}
}
