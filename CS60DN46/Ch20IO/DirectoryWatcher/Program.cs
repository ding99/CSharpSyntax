using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryWatcher {
	class Program {
		static void Main() {
			Console.WriteLine("***** The Amazing File Watcher App *****");
			Watching();
			Console.ResetColor();
		}

		private static void Watching() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Use FileSystemWatcher");
		}
	}
}
