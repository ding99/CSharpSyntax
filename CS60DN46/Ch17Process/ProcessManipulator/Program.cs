using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		}
	}
}
