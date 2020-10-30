using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			Console.ForegroundColor = ConsoleColor.Cyan;

			string path = @"E:\workFolder\cs60\ch20\files\reminders.txt";
			Console.WriteLine($"Here are your thoughts: (from file <{path}>)");

			using (StreamReader sr = File.OpenText(path)) {
				string input = null;

				while ((input = sr.ReadLine()) != null)
					Console.WriteLine(input);
			}
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
