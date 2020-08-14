using System;

namespace CustomInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Interfaces *****");
			InvokeInterface();
			DetermineInterface();
			Console.ResetColor();
		}

		static void DetermineInterface()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Determine whether a type supports a specific interface");

			Circle c = new Circle();

			Console.WriteLine($"Circle supports IPointy: <{c is IPointy}>");
			Console.WriteLine($"Triangle supports IPointy: <{new Triangle() is IPointy}>");

			IPointy ip = null;
			try
			{
				ip = (IPointy)c;
				Console.WriteLine($"The points is {ip.Points}");
			}
			catch(InvalidCastException e)
			{
				Console.WriteLine($"Invalid cast error: {e.Message}");
			}
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
