using System;

namespace SimpleGC {
	class Program {
		static void Main() {
			Console.WriteLine("***** Classs, Objects and References *****");
			GCBasics();
			ExamineGC();
			Console.ResetColor();
		}

		static void ExamineGC() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> System.GC");

			Console.WriteLine($"Estimated bytes on heap: <{GC.GetTotalMemory(false)}> ");
			Console.WriteLine($"This OS has {(GC.MaxGeneration + 1)} object generations.");

			Car car = new Car("Zippy", 100);
			Console.WriteLine($"<{car.ToString()}>: Generation of car is <{GC.GetGeneration(car)}>");

		}

		static void GCBasics() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> GC Basics");

			//Create a Car object on the managed heap
			//A reference to this object is returned ("refToMyCar")
			Car refToMyCar = new Car("Zippy", 50);
			//dot operator is use to invoke member on the object
			Console.WriteLine($"dispaly [{refToMyCar.ToString()}]");
			
			refToMyCar = null;
			Console.Write($"dispaly(null)- ");
			try {
				Console.Write($"[{refToMyCar.ToString()}]");
			} catch(Exception e) {
				Console.Write($"Error: {e.Message}");
			}
			Console.WriteLine();
		}
	}
}
