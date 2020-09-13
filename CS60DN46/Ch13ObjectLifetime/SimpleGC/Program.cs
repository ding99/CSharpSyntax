using System;
using System.Security.AccessControl;

namespace SimpleGC {
	class Program {
		static void Main() {
			Console.WriteLine("***** Classs, Objects and References *****");
			GCBasics();
			ExamineGC();
			ForcingGC();
			Console.ResetColor();
		}

		static void ForcingGC() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Trigger GC");

			Console.WriteLine($"Bytes on heap: <{GC.GetTotalMemory(false)}> ");

			Car car = new Car("Zippy", 100);
			Console.WriteLine($"Generation of <{car}> is: <{GC.GetGeneration(car)}>");

			int n = 50000;
			object[] objects = new object[n];
			for (int i = 0; i < n; i++) objects[i] = new object();

			GC.Collect(0, GCCollectionMode.Forced);
			GC.WaitForPendingFinalizers();
			Console.WriteLine("Forced GC 0");
			Console.WriteLine($"Bytes on heap: <{GC.GetTotalMemory(false)}> ");
			Console.WriteLine($"Generation of <{car}> is: <{GC.GetGeneration(car)}>");

			if(objects[9000] != null)
				Console.WriteLine($"Generaton of objects[9000] is <{GC.GetGeneration(objects[9000])}>");
			else Console.WriteLine("objecs[9000] is no longer alive.");

			Console.WriteLine($"Swept times: Gen0 <{GC.CollectionCount(0)}>, Gen1 <{GC.CollectionCount(1)}>, Gen2 <{GC.CollectionCount(2)}>");
			Console.WriteLine($"Bytes on heap: <{GC.GetTotalMemory(false)}> ");
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
