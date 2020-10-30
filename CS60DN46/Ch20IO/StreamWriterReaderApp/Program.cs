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
			Console.ResetColor();
		}

		private static void Writing() {
			Console.ForegroundColor = ConsoleColor.Yellow;

			string path = @"E:\workFolder\cs60\ch20\files\reminders.txt";

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
