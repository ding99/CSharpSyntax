using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryWatcher {
	class Program {
		static void Main() {
			Console.WriteLine("***** The Amazing File Watcher *****");
			Watching();
			Console.ResetColor();
		}

		private static void Watching() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Use FileSystemWatcher");

			string folder = @"E:\workFolder\cs60\ch20\watchFolder";

			FileSystemWatcher watcher = new FileSystemWatcher();
			try {
				watcher.Path = folder;
			} catch(ArgumentException e) {
				Console.WriteLine(e.Message);
				return;
			}

			watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
			watcher.Filter = "*.txt";

			watcher.Changed += new FileSystemEventHandler(OnChanged);
			watcher.Created += new FileSystemEventHandler(OnChanged);
			watcher.Deleted += new FileSystemEventHandler(OnChanged);
			watcher.Renamed += new RenamedEventHandler(OnRemaned);

			watcher.EnableRaisingEvents = true;

			Console.WriteLine(@"Press 'q' to quit app.");
			while (Console.Read() != 'q') ;
		}

		private static void OnChanged(object source, FileSystemEventArgs e) {
			Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
		}

		private static void OnRemaned(object source, RenamedEventArgs e) {
			Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
		}
	}
}
