using System;

namespace InterfaceHierarchy
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Simple Interface Hierarchy *****");
			Simples();
			Console.ResetColor();
		}

		static void Simples()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> simple hierarchy");

			BitmapImage bitmap = new BitmapImage();
			bitmap.Draw();
			bitmap.DrawInBoundingBox(10, 10, 100, 150);
			bitmap.DrawUpsideDown();

			IAdvancedDraw ia = bitmap as IAdvancedDraw;
			if (ia != null)
				ia.DrawUpsideDown();

		}
	}
}
