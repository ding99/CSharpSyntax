
using System;

namespace ForDasm {
	class Program {
		static void Main() {
			System.Console.WriteLine("== Reference for DeAsm");
			People();
			Calculation();
		}

		private static void Calculation() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Calculating");
			Calculator cal = new Calculator();
			int num1 = 3;
			int num2 = 5;
			int res = cal.Add(num1, num2);
			Console.WriteLine($"The sum of {num1} and {num2} is {res}.");
		}

		private static void People() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Jason's information");
			Person jason = new Person();
			jason.Name = "Jason";
			jason.Age = 25;
			jason.Weight = 160.7;
			System.Console.WriteLine($"Name:{jason.Name}, Age:{jason.Age}, Weight:{jason.Weight}");
		}
	}
}
