using System;

namespace AutoProps
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Automatic Properties *****");
			Status();
			Console.ResetColor();
		}

		static void Status()
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
