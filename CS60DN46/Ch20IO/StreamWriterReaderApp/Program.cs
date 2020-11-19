using System;
using System.IO;

namespace StreamWriterReaderApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** StreanWriter / StreamReader *****");
			Writing();
			Reading();
			Console.ResetColor();
		}

		private static void Reading() {
			string path = @"E:\workFolder\cs60\ch20\files\reminders.txt";
			Console.WriteLine($"File <{path}>");
			string input = null;

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"Using File Type to read file");
			using (StreamReader sr = File.OpenText(path))
				while ((input = sr.ReadLine()) != null)
					Console.WriteLine(input);

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("-> Create StreamReader object Directly");
			using (StreamReader sr = new StreamReader(path))
				while ((input = sr.ReadLine()) != null)
					Console.WriteLine(input);
		}

		private static void Writing() {
			Console.ForegroundColor = ConsoleColor.Yellow;

			string path = @"E:\workFolder\cs60\ch20\files\reminders.txt";
			Console.WriteLine($"Write some message to file <{path}>");

			using(StreamWriter wr = File.CreateText(path)) {
				wr.WriteLine("Don't forget Mother's Day this year...");
				wr.WriteLine("Don't forget Father's Day this year...");
				wr.WriteLine("Don't forget these numbers:");
				for (int i = 0; i < 10; i++) wr.Write(i + " ");
				wr.Write(wr.NewLine);
			}

			Console.WriteLine("Created file and wrote some thoughts...");
		}
	}
}
