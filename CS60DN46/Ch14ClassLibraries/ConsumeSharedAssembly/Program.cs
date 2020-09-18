using System;
using CarLibrary;

namespace ConsumeSharedAssembly {
	class Program {
		static void Main() {
			Console.WriteLine("***** Consume a Shared Assembly *****");
			Consuming();
			Console.ResetColor();
		}

		//Notice: CarLibrary - Properties - CopyLocal: False
		static void Consuming() {
			Console.ForegroundColor = ConsoleColor.Yellow;

			SportsCar car = new SportsCar("Shared", 200, 100);
			car.TurboBoost();

			Console.WriteLine("Consumed");
		}
	}
}
