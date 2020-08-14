﻿using System;

namespace CustomInterface
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Interfaces *****");
			InvokeInterface();
			DetermineInterface();
			ByAs();
			ByIs();
			Console.ResetColor();
		}

		static void ByIs()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Using Is keyword");

			Shape[] shapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
			for (int i = 0; i < shapes.Length; i++)
			{
				shapes[i].Draw();
				if(shapes[i] is IPointy)
					Console.WriteLine($"-> Points: {((IPointy)shapes[i]).Points}");
				else Console.WriteLine($"-> {shapes[i].PetName}\'s not pointy!");
				if (shapes[i] is IDraw3D)
					DrawIn3D((IDraw3D)shapes[i]);
			}
		}
		static void DrawIn3D(IDraw3D i3d)
		{
			Console.WriteLine($"-> Drawing IDraw3D compatible type {i3d.GetType().Name}");
			i3d.Draw3D();
		}

		static void ByAs()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Using As keyword");

			Hexagon h2 = new Hexagon("Peter");
			IPointy ip2 = h2 as IPointy;

			if(ip2 != null)
				Console.WriteLine($"Points: {ip2.Points}");
			else
				Console.WriteLine("OOPS! Not pointy...");
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
