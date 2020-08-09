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
			Console.ResetColor();
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
