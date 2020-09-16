using CarLibrary;
using System;

namespace CSharpCarClient {
	class Program {
		static void Main() {
			Console.WriteLine("***** C# CarLibrary Client App *****");
			UseClass();
			Console.ResetColor();
		}

		static void UseClass() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> use custom class");

			SportsCar viper = new SportsCar("Viper", 240, 40);
			viper.TurboBoost();

			MiniVan van = new MiniVan();
			van.TurboBoost();

			Console.WriteLine("Done");
		}
	}
}
