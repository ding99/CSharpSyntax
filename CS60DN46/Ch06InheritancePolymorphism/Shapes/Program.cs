using System;

namespace Shapes
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Polymorphic Interface *****");
			Abstract();
			SubArray();
			Console.ResetColor();
		}

		static void SubArray()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Array SubClass");

			Shape[] shapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };
			foreach (Shape s in shapes) s.Draw();
		}

		static void Abstract()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Abstract");

			Hexagon hex = new Hexagon("Beth"); hex.Draw();
			Circle cir = new Circle("Cindy"); cir.Draw();
		}
	}
}
