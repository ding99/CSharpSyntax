using System;

namespace AnonymousTypes {
	class Program {
		static void Main() {
			Console.WriteLine("***** Anonymous Types *****");
			UseAnonymousType();
			ReflectInfo();
			EqualityTest();
			NestedAnonymousTypes();
			Console.ResetColor();
		}

		static void NestedAnonymousTypes() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Anonymous Types containing Anonymous Types");

			var purchaseItem = new {
				Time = DateTime.Now,
				Item = new { Color = "Red", Make = "Saab", Speed = 55 },
				Price = 34
			};

			ReflectOverAnonymousType(purchaseItem);
		}

		static void EqualityTest() {
			Console.WriteLine("=> Equality test");

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("-> Same definitions with same order");
			var firstCar = new { Color = "Black", Make = "Saab", Speed = 55 };
			var secondCar = new { Color = "Black", Make = "Saab", Speed = 55 };
			Prints(firstCar, secondCar);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("-> Same definitions with different order");
			var thirdCar = new { Make = "Saab", Color = "Black", Speed = 55 };
			Prints(firstCar, thirdCar);
		}

		static void Prints(object a, object b) {
			Console.WriteLine($"Same anonymous objects(by Equals()): {a.Equals(b)}");
			Console.WriteLine($"Same anonymous objects(by ==): {a == b}");
			Console.WriteLine($"We are both the same type: {a.GetType().Name == b.GetType().Name}");

			Console.BackgroundColor = ConsoleColor.Yellow; ReflectOverAnonymousType(a);
			Console.BackgroundColor = ConsoleColor.White; ReflectOverAnonymousType(b);
			Console.BackgroundColor = ConsoleColor.Black;
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

/**
***** Anonymous Types *****
=> Defining an Anonymous Types
My car is a Bright Pink Saab.
You have a Black BWM going 90 MPH
ToString() == { Make = BWM, Color = Black, Speed = 90 }

=> Internal Representation of Anonymous Types
obj is an instance of: <>f__AnonymousType0`3
Base class of <>f__AnonymousType0`3 is System.Object
obj.ToString() == { Color = Pink, Make = Saab, Speed = 55 }
obj.GetHashCode() == 1152314597

=> Equality test
-> Same definitions with same order
Same anonymous objects(by Equals()): True
Same anonymous objects(by ==): False
We are both the same type: True
obj is an instance of: <>f__AnonymousType0`3
Base class of <>f__AnonymousType0`3 is System.Object
obj.ToString() == { Color = Black, Make = Saab, Speed = 55 }
obj.GetHashCode() == -1268376977
obj is an instance of: <>f__AnonymousType0`3
Base class of <>f__AnonymousType0`3 is System.Object
obj.ToString() == { Color = Black, Make = Saab, Speed = 55 }
obj.GetHashCode() == -1268376977

-> Same definitions with different order
Same anonymous objects(by Equals()): False
Same anonymous objects(by ==): False
We are both the same type: False
obj is an instance of: <>f__AnonymousType0`3
Base class of <>f__AnonymousType0`3 is System.Object
obj.ToString() == { Color = Black, Make = Saab, Speed = 55 }
obj.GetHashCode() == -1268376977
obj is an instance of: <>f__AnonymousType1`3
Base class of <>f__AnonymousType1`3 is System.Object
obj.ToString() == { Make = Saab, Color = Black, Speed = 55 }
obj.GetHashCode() == 387154663
**/