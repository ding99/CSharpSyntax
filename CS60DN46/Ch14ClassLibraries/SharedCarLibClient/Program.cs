using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

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

			SportsCar viper = new SportsCar("Shared", 150, 60);
			viper.TurboBoost();

			MiniVan van = new MiniVan();
			van.TurboBoost();

			Console.WriteLine("Done");
		}
	}
}
