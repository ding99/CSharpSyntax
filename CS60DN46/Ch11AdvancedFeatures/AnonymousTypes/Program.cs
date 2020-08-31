using System;

namespace AnonymousTypes {
	class Program {
		static void Main() {
			Console.WriteLine("***** Anonymous Types *****");
			UseAnonymousType();
			ReflectInfo();
			Console.ResetColor();
		}

		static void ReflectInfo() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Internal Representation of Anonymous Types");

			var car = new { Color = "Pink", Make = "Saab", Speed = 55 };
			ReflectOverAnonymousType(car);
		}

		static void ReflectOverAnonymousType(object obj) {
			Console.WriteLine($"obj is an instance of: {obj.GetType().Name}");
			Console.WriteLine($"Base class of {obj.GetType().Name} is {obj.GetType().BaseType}");
			Console.WriteLine($"obj.ToString() == {obj.ToString()}");
			Console.WriteLine($"obj.GetHashCode() == {obj.GetHashCode()}");
		}

		static void UseAnonymousType() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Defining an Anonymous Types");

			var myCar = new { Color = "Bright Pink", Make = "Saab", Speed = 55 };
			Console.WriteLine($"My car is a {myCar.Color} {myCar.Make}.");

			BuildAnonymousType("BWM", "Black", 90);
		}

		static void BuildAnonymousType(string make, string color, int speed) {
			var car = new { Make = make, Color = color, Speed = speed };
			Console.WriteLine($"You have a {car.Color} {car.Make} going {car.Speed} MPH");

			Console.WriteLine($"ToString() == {car.ToString()}");
		}
	}
}
