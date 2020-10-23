using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SimpleMultiThreadApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Working with the ThreadStart Delegate *****");
			UseThreadStart();
			Console.ResetColor();
		}

		private static void UseThreadStart() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> The Amazing Thread App");
			Console.Write("Do you want [1] or [2] threads?");
			string threadCount = Console.ReadLine();

			Thread primary = Thread.CurrentThread;
			primary.Name = "Primary";

			Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing primary");

			Printer p = new Printer();
			switch (threadCount) {
				case "2":
					Thread backgroud = new Thread(new ThreadStart(p.PrintNumbers));
					backgroud.Name = "Secondary";
					backgroud.Start();
					break;
				case "1":
					p.PrintNumbers();
					break;
				default:
					Console.WriteLine("I don't know what you want... y ou get 1 thread.");
					goto case "1";
			}

			MessageBox.Show("I'm busy!", "Work on primary thread...");
		}
	}
}
