using CarLibrary;
using System;

namespace PublisherPolicy {
	class Program {
		static void Main() {
			Console.WriteLine("***** Disabling Publisher Policy *****");
			UseSharedAssembly();
			Console.ResetColor();
		}
		static void UseSharedAssembly() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> use shared assembly");

			SportsCar sport = new SportsCar("Shared", 160, 60);
			sport.TurboBoost();

			Console.WriteLine("- Done");
		}
	}
}
