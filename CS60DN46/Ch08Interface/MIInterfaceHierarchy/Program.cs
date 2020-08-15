using System;

namespace MIInterfaceHierarchy
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Multiple Inheritance *****");
			Multis();
			Console.ResetColor();
		}

		static void Multis()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Rectangle rec = new Rectangle();
			(rec as IDrawable).Draw();
			(rec as IPrintable).Draw();
			rec.Print();
			Console.WriteLine($"Rectangle: Number of sides {rec.GetNumberOfSides()}");

			Console.ForegroundColor = ConsoleColor.Yellow;
			Square squ = new Square();
			(squ as IDrawable).Draw();
			(squ as IPrintable).Draw();
			squ.Print();
			Console.WriteLine($"Square: Number of sides {squ.GetNumberOfSides()}");
		}
	}
}
