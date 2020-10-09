using System;

namespace ApplyingAttributes {
	class Program {
		static void Main() {
			Console.WriteLine("***** Applying Attributes *****");
			ApplyAttributes();
			Console.ResetColor();
		}

		static void ApplyAttributes() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Apply Attributes to classes");

			Motorcycle motor = new Motorcycle();

			HorseAndBuggy mule = new HorseAndBuggy();
		}
	}
}
