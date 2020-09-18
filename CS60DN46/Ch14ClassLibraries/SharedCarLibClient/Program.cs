using CarLibrary;
using System;

namespace SharedCarLibClient {
	class Program {
		static void Main() {
			Console.WriteLine("***** C# Shared CarLibrary Client App *****");
			UseSharedAssembly();
			Console.ResetColor();
		}

		static void UseSharedAssembly() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> use shared assembly");

			SportsCar sport = new SportsCar("Shared", 150, 60);
			sport.TurboBoost();

			Console.WriteLine("Done");
		}
	}
}
