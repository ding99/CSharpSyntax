using System;

namespace Parsings {
	public class Partial {
		public Partial() { Console.ForegroundColor = ConsoleColor.Yellow; }

		public void Start() {
			string source = string.Empty;
			int target = 0;

			Console.Write("Please enter an input value :");
			try {
				target = Convert.ToInt32(source = Console.ReadLine());
				//size=45000, 4500, ...
			}
			catch (Exception e) {
				Console.WriteLine($"Error: {e.Message}");
			}

			Console.WriteLine($"Input value is : {source}");
			Console.WriteLine($"The output is : {target}");
		}
	}
}
