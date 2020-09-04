using System;
using System.Linq;

namespace LinqExpressions {
	class Program {
		static void Main() {
			Console.WriteLine("***** Query Expressions *****");
			Expression();
			Console.ResetColor();
		}

		static void Expression() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			ProductInfo[] items = new[] {
				new ProductInfo{Name="Mac's Coffee",Desc="Coffee with TEETH",Number = 24},
				new ProductInfo{Name="Milk Maid Milk",Desc="Milk cow's love",Number = 100},
				new ProductInfo{Name="Pure Silk Tofu",Desc="Bland as Possible",Number = 120},
				new ProductInfo{Name="Cruchy Pops",Desc="Cheezy, peppery goodness",Number = 2},
				new ProductInfo{Name="RipOff Water",Desc="From the tap to your wallet",Number = 100},
				new ProductInfo{Name="Classic Valpo pizza",Desc="Everyone loves pizza!",Number = 73}
			};

			Console.WriteLine($"Items (size {items.Count()})");
			foreach(var p in items)
				Console.WriteLine($" {p}");

			Console.ForegroundColor = ConsoleColor.Cyan; ListNames(items);
			Console.ForegroundColor = ConsoleColor.Green; OverStacks(items);
			Console.ForegroundColor = ConsoleColor.DarkYellow; NewDataTypes(items);
			Console.ForegroundColor = ConsoleColor.DarkCyan; ReturnAsArray(items);
			Console.ForegroundColor = ConsoleColor.Red; Reverse(items);
			Console.ForegroundColor = ConsoleColor.Blue; Sorting(items);
		}

		static void Sorting(ProductInfo[] products) {
			Console.WriteLine("-> Sorting Expression (overstock)");
			var sorts = from p in products where p.Number > 25 orderby p.Name select p;
			Console.Write($"Items (size {sorts.Count()})");
			foreach (var p in sorts)
				Console.Write($" <{p.Name}>");
			Console.WriteLine();
		}

		static void Reverse(ProductInfo[] products) {
			Console.WriteLine("-> Reverse result sets (overstock)");
			var reverses = (from p in products where p.Number > 25 select p).Reverse();
			Console.Write($"Items (size {reverses.Count()})");
			foreach (var p in reverses)
				Console.Write($" <{p.Name}>");
			Console.WriteLine();
		}

		static void ReturnAsArray(ProductInfo[] products) {
			Array objs = GetSubSet(products);
			Console.WriteLine("-> Return as Array (overstock)");
			Console.WriteLine($"Items (size {objs.Length})");
			foreach (var p in objs)
				Console.WriteLine($" {p}");
		}
		static Array GetSubSet(ProductInfo[] products) {
			return (from p in products where p.Number > 25 select new { p.Name, p.Desc }).ToArray();
		}

		static void NewDataTypes(ProductInfo[] products) {
			Console.WriteLine("-> New data types (Name and Desc)");
			var nameDesc = from p in products select new { p.Name, p.Desc };
			Console.WriteLine($"Items (size {nameDesc.Count()})");
			foreach (var p in nameDesc)
				Console.WriteLine($" {p}");
		}

		static void OverStacks(ProductInfo[] products) {
			Console.WriteLine("-> Basic Where Syntax (overstock)");
			var overstocks = from p in products where p.Number > 25 select p;
			Console.Write($"Items (size {overstocks.Count()})");
			foreach (var p in overstocks)
				Console.Write($" <{p.Name}>");
			Console.WriteLine();
		}

		static void ListNames(ProductInfo[] products) {
			Console.WriteLine("-> Basic Select Syntax");

			Console.WriteLine("All product names:");
			var alls = from p in products select p.Name;
			Console.Write($"Names (size {alls.Count()}):");
			foreach(var prod in alls)
				Console.Write($" <{prod}>");
			Console.WriteLine();
		}
	}
}
