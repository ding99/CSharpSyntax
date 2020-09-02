using System;
using System.Collections.Generic;

namespace LinqOverCollections {
	class Program {
		static void Main(string[] args) {
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
				new Car{ Name = "Melvin", Color = "White", Speed = 54, Make = "Ford" }
			};
		}

	}
}
