using System;

namespace AutoProps
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Automatic Properties *****");
			CarStatus();
			ClassDefault();
			PropInitialization();
			Console.ResetColor();
		}

		static void PropInitialization()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Initialization of Automatic Properties");

			Garage g1 = new Garage();
			Console.Write($"G1: Number of Cars {g1.NumberofCars}. ");
			g1.Auto.Display();

			Garage g2 = new Garage(new Car { Name = "David", Color = "Red", Speed = 60 }, 2);
			Console.Write($"G2: Number of Cars {g2.NumberofCars}. ");
			g2.Auto.Display();
		}

		static void ClassDefault()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Class Default value");

			Car c = new Car { Name = "Mike", Speed = 50, Color = "Grey" };
			c.Display();

			Garage g = new Garage();
			g.Auto = c;
			Console.WriteLine($"Number of Cars: {g.NumberofCars}");

			try
			{
				Console.WriteLine($"Car Name: {g.Auto.Name}");
			}
			catch(Exception e)
			{
				Console.WriteLine($"Error: {e.Message}");
			}
		}

		static void CarStatus()
		{
			Console.ForegroundColor = ConsoleColor.Green; ;
			Console.WriteLine("=> Status");
			Car c = new Car() { Name = "Frank", Color = "Red" };
			Console.WriteLine($"Your car is named {c.Name}?");
			c.Display();

			c.Speed = 55; c.Display();
		}
	}
}
