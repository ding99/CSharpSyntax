using System;

namespace SimpleGC {
	class Program {
		static void Main() {
			Console.WriteLine("***** Classs, Objects and References *****");
			GCBasics();
			Console.ResetColor();
		}

		static void GCBasics() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> GC Basics");

			Car refToMyCar = new Car("Zippy", 50);
			Console.WriteLine(refToMyCar.ToString());
		}
	}
}
