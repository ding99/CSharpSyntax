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
			Shadowing();
			Casting();
			Console.ResetColor();
		}

		static void Casting()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Casting Rules");
			ThreeDCircle threed = new ThreeDCircle();
			Console.Write("Drawing via New Class: "); threed.Draw();
			Console.Write("Drawing via Base Class: "); ((Circle)threed).Draw();
		}

		static void Shadowing()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Shadowing");

			ThreeDCircle threed = new ThreeDCircle();
			threed.Draw();
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
