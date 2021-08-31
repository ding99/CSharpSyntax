using System;

namespace Parsings {
	public class Partial {
		public Partial() { Console.ForegroundColor = ConsoleColor.Yellow; }

		public void Start() {
			Parsing("2345");
			Parsing("size=2345");
			//string source = string.Empty;
			//int target = 0;

			//Console.Write("Please enter an input value :");
			//try {
			//	target = Convert.ToInt32(source = Console.ReadLine());
			//	//size=45000, 4500, ...
			//}
			//catch (Exception e) {
			//	Console.WriteLine($"Error: {e.Message}");
			//}

			//Console.WriteLine($"Input value is : {source}");
			//Console.WriteLine($"The output is : {target}");
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
