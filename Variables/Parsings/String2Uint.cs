using System;
using System.Linq;

namespace Parsings {
	public class String2Uint {
		public String2Uint() { Console.ForegroundColor = ConsoleColor.Cyan; }

		public void Start() {
			Parsing("ffml");
			Parsing("vtt ");
			Parsing("webvtt");
		}

		private void Parsing(string source) {
			Console.Write($"Source [{source}]");

			try {
				uint target1 = ((uint)source[0] << 24) + ((uint)source[1] << 16) + ((uint)source[2] << 8) + source[3];
				Console.Write($" Target1 [{target1.ToString("x")}]");
			}
			catch(Exception e) {
				Console.Write($" [{e.Message}]");
			}

			try {
				uint target2 = (uint)source.Substring(0,4).Select(c => (int)c).Aggregate(0, (x, y) => (x << 8) + y);
				Console.Write($" Target2 [{target2.ToString("x")}]");
			}
			catch (Exception e) {
				Console.Write($" [{e.Message}]");
			}

			Console.WriteLine();
		}
	}
}
