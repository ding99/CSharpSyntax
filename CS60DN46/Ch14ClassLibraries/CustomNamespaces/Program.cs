using MyShapes;
using System;

namespace CustomNamespaces {
	class Program {
		static void Main() {
			Console.WriteLine("***** Custom Namespaces *****");
			CallClass();
			Console.ResetColor();
		}

		static void CallClass() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Use other namespaces");

			Circle c = new Circle(); c.Print();
			Hexagon h = new Hexagon(); h.Print();
			Square s = new Square(); s.Print();
		}
	}
}
