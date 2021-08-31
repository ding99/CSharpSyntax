using System;

namespace Parsings {
	public class Partial {
		public Partial() { Console.ForegroundColor = ConsoleColor.Yellow; }

		public void Start() {
			Parsing("2345");
			Parsing("size=2345");
		}

		private void Parsing(string source) {
			Console.Write($"Source [{source}], ");

			try {
				int target = Convert.ToInt32(source);
				Console.WriteLine($"Parsed [{target}]");
			}
			catch (Exception e) {
				Console.WriteLine($"Error: [{e.Message}]");
			}
		}
	}
}
