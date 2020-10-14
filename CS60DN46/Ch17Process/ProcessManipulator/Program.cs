using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace ProcessManipulator {
	class Program {
		static void Main() {
			Console.WriteLine("***** Processes *****");
			ListAllRunningProcesses();
			SpecificProcess();
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

		private static void SpecificProcess() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Specific Process");

			IEnumerable<Process> runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
			Process theProc = null;

			try {
				Console.WriteLine($"{runningProcs.Count()} processes");
				int n = 2;
				if (runningProcs.Count() > n) {
					int pid = runningProcs.ToList()[n].Id;
					theProc = Process.GetProcessById(pid);
					Console.WriteLine($"{theProc.Id} / {theProc.ProcessName}");
				}
			}
			catch(ArgumentException e) {
				Console.WriteLine(e.Message);
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}
