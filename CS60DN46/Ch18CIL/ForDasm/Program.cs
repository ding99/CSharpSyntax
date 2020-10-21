
using System;

namespace ForDasm {
	class Program {
		static void Main() {
			Console.WriteLine("== Reference for DeAsm");
			People();
			Calculation();
		}

		private static void Calculation() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Calculating");
			ForDasmSub.Calculator cal = new ForDasmSub.Calculator();
			int num1 = 3;
			int num2 = 5;
			int res = cal.Add(num1, num2);
			Console.WriteLine($"The sum of {num1} and {num2} is {res}.");
		}

		private static void People() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Jason's information");
			ForDasmSub.Person jason = new ForDasmSub.Person();
			jason.Name = "Jason";
			jason.Age = 25;
			jason.Weight = 160.7;
			Console.WriteLine($"Name:{jason.Name}, Age:{jason.Age}, Weight:{jason.Weight}");
		}
	}
}
