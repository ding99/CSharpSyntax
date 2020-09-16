using System;
using Cricle3D = Chapter14.My3DShapes.Circle;

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

			Chapter14.MyShapes.Circle c = new Chapter14.MyShapes.Circle(); c.Print();
			Chapter14.MyShapes.Hexagon h = new Chapter14.MyShapes.Hexagon(); h.Print();
			Chapter14.MyShapes.Square s = new Chapter14.MyShapes.Square(); s.Print();

			Cricle3D c3 = new Cricle3D(); c3.Print();
			Chapter14.My3DShapes.Hexagon h3 = new Chapter14.My3DShapes.Hexagon(); h3.Print();
			Chapter14.My3DShapes.Square s3 = new Chapter14.My3DShapes.Square(); s3.Print();
		}
	}
}
