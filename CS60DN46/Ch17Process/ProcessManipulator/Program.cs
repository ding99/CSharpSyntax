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
				List<Process> list = runningProcs.ToList();

				int n = 5;
				if (runningProcs.Count() > n) {
					int pid = list[n].Id;
					theProc = Process.GetProcessById(pid);
					Console.WriteLine($"{theProc.Id} / {theProc.ProcessName}");
				}

				List<Process> chromes = (from p in runningProcs where p.ProcessName.ToLower().Equals("chrome") select p).ToList();

				Console.WriteLine($"{chromes.Count} chrome processes totally");
				if (chromes.Count > 0)
					EnumThreadsForPid(chromes[0].Id);
			}
			catch(ArgumentException e) {
				Console.WriteLine(e.Message);
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}

		private static void EnumThreadsForPid(int pID) {
			Console.ForegroundColor = ConsoleColor.DarkYellow;

			Process theProc = null;
			try { theProc = Process.GetProcessById(pID); }
			catch (ArgumentException e)
			{ Console.WriteLine(e.Message); return; }

			Console.WriteLine($"-> Here are the threads used by {theProc.ProcessName} with pID {pID}");
			ProcessThreadCollection theThds = theProc.Threads;

			foreach(ProcessThread t in theThds) {
				string info = $"Thread ID {t.Id},{Spaces(t.Id)}\tTime {t.StartTime.ToShortTimeString()},\tState {t.ThreadState},\tPriority {t.PriorityLevel}";
				Console.WriteLine(info);
			}
		}
		private static string Spaces(int id) {
			string s = string.Empty;
			for (int i = id.ToString().Length; i < 5; i++)
				s += " ";
			return s;
		}
	}
}
