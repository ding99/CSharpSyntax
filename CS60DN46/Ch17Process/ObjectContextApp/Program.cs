using System;

namespace ObjectContextApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Inspecting an Object's Context *****");
			ObjectContext();
			Console.ResetColor();
		}

		private static void ObjectContext() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Object Context");

			SportsCar car1 = new SportsCar();
			Console.WriteLine();

			SportsCar car2 = new SportsCar();
			Console.WriteLine();

			SportsCarTS syncCar = new SportsCarTS();
			Console.WriteLine();
		}
	}
}
