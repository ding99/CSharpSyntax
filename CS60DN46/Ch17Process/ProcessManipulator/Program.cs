using System;
using System.Diagnostics;
using System.Linq;

namespace ProcessManipulator {
	class Program {
		static void Main() {
			Console.WriteLine("***** Processes *****");
			ListAllRunningProcesses();

			Console.ResetColor();
		}

		private static void ListAllRunningProcesses() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> List All Running Processes");

			//get all the processes on the local machine, ordered by PID
			var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
			Console.WriteLine($"-> {runningProcs.Count()} running processes totally");
			foreach(var p in runningProcs)
				Console.Write($" [{p.Id}:{p.ProcessName}]");
			Console.WriteLine();
		}
	}
}
