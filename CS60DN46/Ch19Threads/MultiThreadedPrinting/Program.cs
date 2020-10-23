﻿using System;
using System.Threading;

namespace MultiThreadedPrinting {
	class Program {
		static void Main() {
			Console.WriteLine("***** Synchronizing Threads *****");
			Console.ForegroundColor = ConsoleColor.Cyan;

			Printer p = new Printer();

			Thread[] threads = new Thread[10];
			for(int i = 0; i < 10; i++) {
				threads[i] = new Thread(new ThreadStart(p.PrintNumbers));
				threads[i].Name = string.Format("W{0}", i);
			}

			foreach (Thread t in threads)
				t.Start();

			Thread.Sleep(500);
			Console.ResetColor();
		}
	}
}
