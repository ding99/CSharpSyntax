using System;
using System.Security.AccessControl;
using System.Threading;

namespace ThreadStats {
	class Program {
		static void Main() {
			Console.WriteLine("***** Statistics about the Current Thread *****");
			Stats();
			Console.ResetColor();
		}

		private static void Stats() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Primary Thread Stats");

			Thread primary = Thread.CurrentThread;
			primary.Name = "ThePrimaryThread";

			Console.WriteLine($"Name of current AppDomain: <{Thread.GetDomain().FriendlyName}> with domain ID <{Thread.GetDomainID()}>");
			Console.WriteLine($"ID of current Context: <{Thread.CurrentContext.ContextID}>");

			Console.WriteLine($"Thread Name: <{primary.Name}>");
			Console.WriteLine($"Has thread started?: <{primary.IsAlive}>");
			Console.WriteLine($"Priority level: <{primary.Priority}>");
			Console.WriteLine($"Thread State: <{primary.ThreadState}>");

			primary.Priority = ThreadPriority.AboveNormal;
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"Priority level (changed): <{primary.Priority}>");
		}
	}
}
