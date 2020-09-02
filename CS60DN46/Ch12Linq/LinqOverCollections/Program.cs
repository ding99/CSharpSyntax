using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqOverCollections {
	class Program {
		static void Main() {
			Console.WriteLine("***** Linq Queries to Collection Objects *****");
			GenericCollections();
			Console.ResetColor();
		}

		static void GenericCollections() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Linq Over Generic Collections");
			List<Car> cars = new List<Car> {
				new Car{ Name = "Henry", Color = "Silver", Speed = 100, Make = "BWM" },
				new Car{ Name = "Daisy", Color = "Tan", Speed = 90, Make = "BWM" },
				new Car{ Name = "Mary", Color = "Black", Speed = 55, Make = "VM" },
				new Car{ Name = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
				new Car{ Name = "Melvin", Color = "White", Speed = 56, Make = "Ford" }
			};

			GetFastCars(cars);
		}
		static void GetFastCars(List<Car> cars) {
			Console.Write($"-> Cars (size {cars.Count()}):");
			foreach (var car in cars)
				Console.Write($" <{car.Name}>");
			Console.WriteLine();

			var fastCars = from c in cars where c.Speed > 55 select c;
			Console.Write($"-> Fast Cars (size {fastCars.Count()}):");
			foreach(var car in fastCars)
				Console.Write($" <{car.Name}>");
			Console.WriteLine();
		}

	}
}
