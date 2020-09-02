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
				new Car{ Name = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
				new Car{ Name = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
				new Car{ Name = "Mary", Color = "Black", Speed = 55, Make = "VM" },
				new Car{ Name = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
				new Car{ Name = "Melvin", Color = "White", Speed = 56, Make = "Ford" }
			};

			Console.Write($"-> Cars (size {cars.Count()}):");
			foreach (var car in cars)
				Console.Write($" <{car.Name}/{car.Make}/{car.Speed}>");
			Console.WriteLine();

			GetFastCars(cars);
			GetFastBMWs(cars);
		}
		static void GetFastCars(List<Car> cars) {
			var fastCars = from c in cars where c.Speed > 55 select c;
			Console.Write($"-> Fast (>55) Cars (size {fastCars.Count()}):");
			foreach(var car in fastCars)
				Console.Write($" <{car.Name}>");
			Console.WriteLine();
		}
		static void GetFastBMWs(List<Car> cars) {
			var fastCars = from c in cars where c.Speed > 90 && c.Make == "BMW" select c;
			Console.Write($"-> Too Fast (>90.BMW) Cars (size {fastCars.Count()}):");
			foreach (var car in fastCars)
				Console.Write($" <{car.Name}>");
			Console.WriteLine();
		}
	}
}
