using CarLibrary;
using System;

namespace CodeBaseClient {
	class Program {
		static void Main() {
			Console.WriteLine("***** Code Base Client *****");
			CodeBase();
			Console.ResetColor();
		}

		static void CodeBase() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			SportsCar car = new SportsCar();
			car.TurboBoost();
			Console.WriteLine("Sports car has been allocated.");
		}
	}
}
