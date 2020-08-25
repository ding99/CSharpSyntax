using System;

namespace WithGenericCollections
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Generic Collection *****");
			ObjectSorting();
			Console.ResetColor();
		}

		static void ObjectSorting()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Object Sorting");

			Car[] cars = {
	 			new Car("Rusty", 80, 1),
				new Car("Mary", 70, 234),
				new Car("Viper", 60, 34),
				new Car("Mel", 50, 4),
				new Car("Chucky", 30, 5)
			};

			Console.WriteLine("Here is the unordered set of cars:");
			foreach (Car c in cars)
				Console.Write($" ({c.CarID},{c.PetName})");
			Console.WriteLine();

			Array.Sort(cars);
			Console.WriteLine("Here is the ordered set of cars:");
			foreach (Car c in cars)
				Console.Write($" ({c.CarID},{c.PetName})");
			Console.WriteLine();
		}
	}
}
