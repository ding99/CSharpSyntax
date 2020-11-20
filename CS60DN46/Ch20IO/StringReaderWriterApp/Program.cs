using System;
using System.IO;
using System.Text;

namespace StringReaderWriterApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** StringWriter / StringReader *****");
			WriteRead();
			Console.ResetColor();
		}

		private static void WriteRead() {
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
				string msg = "(Hey!! )";
				sb.Insert(6, msg);
				Console.WriteLine($"-> <{sb.ToString()}>");
				sb.Remove(6, msg.Length);
				Console.WriteLine($"-> <{sb.ToString()}>");

				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("-- StringReader");
				using(StringReader reader = new StringReader(writer.ToString())) {
					string input = null;
					while((input = reader.ReadLine()) != null)
						Console.WriteLine(input);
				}
			}
		}
	}
}
