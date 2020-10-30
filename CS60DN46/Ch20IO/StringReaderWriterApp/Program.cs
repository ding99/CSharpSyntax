using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringReaderWriterApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** StringWriter / StringReader *****");
			Writing();
			Reading();
			Console.ResetColor();
		}

		private static void Reading() {
			//string path = @"E:\workFolder\cs60\ch20\files\reminders.txt";
			//string input = null;

			//Console.ForegroundColor = ConsoleColor.Cyan;
			//Console.WriteLine($"Using File Type to read file <{path}>");
			//using (StreamReader sr = File.OpenText(path))
			//	while ((input = sr.ReadLine()) != null)
			//		Console.WriteLine(input);

			//Console.ForegroundColor = ConsoleColor.DarkCyan;
			//Console.WriteLine("-> Create StreamReader Directly");
			//using (StreamReader sr = new StreamReader(path))
			//	while ((input = sr.ReadLine()) != null)
			//		Console.WriteLine(input);
		}

		private static void Writing() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Write some message to memory");

			using (StringWriter writer = new StringWriter()) {
				writer.WriteLine("Don't forget Mother's Day this year...");
				writer.WriteLine("Don't forget Father's Day this year...");

				Console.WriteLine($"Contents of StringWriter:");
				Console.WriteLine(writer);

				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("-- Use GetStringBuilder()");

				StringBuilder sb = writer.GetStringBuilder();
				sb.Insert(0, "Hey!! ");
				Console.WriteLine($"-> <{sb.ToString()}>");
				sb.Remove(0, "Hey!! ".Length);
				Console.WriteLine($"-> <{sb.ToString()}>");
			}
		}
	}
}
