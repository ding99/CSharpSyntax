using System;
using MyShapes;
using My3DShapes;
using Cricle3D = My3DShapes.Circle;

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

			MyShapes.Circle c = new MyShapes.Circle(); c.Print();
			MyShapes.Hexagon h = new MyShapes.Hexagon(); h.Print();
			MyShapes.Square s = new MyShapes.Square(); s.Print();

			Cricle3D c3 = new Cricle3D(); c3.Print();
			My3DShapes.Hexagon h3 = new My3DShapes.Hexagon(); h3.Print();
			My3DShapes.Square s3 = new My3DShapes.Square(); s3.Print();
		}
	}
}
