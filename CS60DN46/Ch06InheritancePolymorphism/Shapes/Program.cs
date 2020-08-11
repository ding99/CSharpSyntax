using System;

namespace Shapes
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Polymorphic Interface *****");
			Abstract();
			Console.ResetColor();
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
