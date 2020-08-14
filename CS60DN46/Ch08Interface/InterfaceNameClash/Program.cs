using System;

namespace InterfaceNameClash
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Interface Name Clashes *****");
			WhichInterface();
			Console.ResetColor();
		}

		static void WhichInterface()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> which interface");

			Octagon oct = new Octagon();
			((IDrawToForm)oct).Draw();
			((IDrawToMemory)oct).Draw();
			((IDrawToPrinter)oct).Draw();
		}
	}
}
