﻿using System;
using System.Threading;

namespace MultiThreadedPrinting {
	class Printer {
		private int n = 0;
		public void PrintNumbers() {
			Console.Write($"\nStart-{Thread.CurrentThread.Name}:");
			for(int i = 0; i < 10; i++) {
				Random r = new Random();
				Thread.Sleep(1000 * r.Next(5));
				Console.Write($" {Thread.CurrentThread.Name}({i}){n++}");
			}
			Console.WriteLine($" End-{Thread.CurrentThread.Name}.");
		}
	}
}
