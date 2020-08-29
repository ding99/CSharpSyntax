using System;

namespace CarEvents {
	class Program {
		static void Main() {
			Console.WriteLine("***** Car Events *****");
			EventKeyword();
			NullConditional();
			CustomArgs();
			Console.ResetColor();
		}

		static void CustomArgs() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Custom Event Arguments");

			CarCustom c1 = new CarCustom("SlugBug", 100, 10);
			c1.AboutToBlow += CarIsAlmostDoomed;
			c1.AboutToBlow += CarAboutToBlow;
			c1.Exploaded += CarExploded;

			Console.WriteLine("===== Speeding up");
			for (int i = 0; i < 7; i++) c1.Accelerate(20);
		}

		static void NullConditional() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Events with Null-Conditional Operator");

			Car c1 = new Car("SlugBug", 100, 10);
			c1.AboutToBlow += CarIsAlmostDoomed;
			c1.AboutToBlow += CarAboutToBlow;

			Car.CarEngineHandler d = new Car.CarEngineHandler(CarExploded);
			c1.Exploaded += d;

			Console.WriteLine("===== Speeding up");
			for (int i = 0; i < 7; i++) c1.Accelerate2(20);
		}

		static void EventKeyword() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Events");

			Car c1 = new Car("SlugBug", 100, 10);
			//c1.AboutToBlow += CarIsAlmostDoomed; //method group conversion
			//c1.AboutToBlow += CarAboutToBlow;
			c1.AboutToBlow += new Car.CarEngineHandler(CarIsAlmostDoomed);
			c1.AboutToBlow += new Car.CarEngineHandler(CarAboutToBlow);

			Car.CarEngineHandler d = new Car.CarEngineHandler(CarExploded);
			c1.Exploaded += d;

			Console.WriteLine("===== Speeding up");
			for (int i = 0; i < 7; i++) c1.Accelerate(20);

			c1.Exploaded -= d;

			c1.Reset();
			Console.WriteLine("----- Speeding up");
			for (int i = 0; i < 7; i++) c1.Accelerate(20);
		}

		#region handlers
		public static void CarExploded(string msg) {
			ConsoleColor fore = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"   {msg}");
			Console.ForegroundColor = fore;
		}
		public static void CarAboutToBlow(string msg) { Console.WriteLine($"   {msg}"); }
		public static void CarIsAlmostDoomed(string msg) {
			ConsoleColor fore = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"=> Critical Message from Car: {msg}");
			Console.ForegroundColor = fore;
		}

		public static void CarExploded(object sender, CarEventArgs e) {
			ConsoleColor fore = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"   {e.msg} at {e.time}");
			Console.ForegroundColor = fore;
		}
		public static void CarAboutToBlow(object sender, CarEventArgs e) { Console.WriteLine($"   {e.msg} at {e.time}"); }
		public static void CarIsAlmostDoomed(object sender, CarEventArgs e) {
			ConsoleColor fore = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"=> Critical Message from Car: {e.msg} at {e.time}");
			Console.ForegroundColor = fore;
		}
		#endregion
	}
}
