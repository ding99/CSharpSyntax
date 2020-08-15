using System;

namespace ComparableCar
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Comparable Interface *****");
			ObjectSorting();
			Console.ResetColor();
		}

		static void ObjectSorting()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Object Sorting");

			Car[] cars = new Car[5];
			cars[0] = new Car("Rusty", 80, 1);
			cars[1] = new Car("Mary", 70, 234);
			cars[2] = new Car("Viper", 60, 34);
			cars[3] = new Car("Mel", 50, 4);
			cars[4] = new Car("Chucky", 30, 5);

			Console.WriteLine("Here is the unordered set of cars:");
			foreach(Car c in cars)
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
