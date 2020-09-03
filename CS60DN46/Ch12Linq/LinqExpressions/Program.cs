using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				Console.WriteLine(p.ToString());

			ListNames(items);
			OverStacks(items);
		}
		static void OverStacks(ProductInfo[] products) {
			Console.WriteLine("-> Basic Where Syntax");
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
