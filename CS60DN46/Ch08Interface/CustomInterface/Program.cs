using System;

namespace CustomInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Interfaces *****");
			InvokeInterface();
			Console.ResetColor();
		}

		static void InvokeInterface()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Invoking Interface");

			Hexagon hex = new Hexagon();
			Console.WriteLine($"Points : {hex.Points}");
		}
	}
}
