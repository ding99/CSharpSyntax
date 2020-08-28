using System;

namespace CarDelegate
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Sending Object State Notification *****");
			AsEvent();
			MultiCast();
			Console.ResetColor();
		}

		static void MultiCast()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Enabling Multicasting");

			Car c1 = new Car("SlugBug", 100, 10);

			c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
			c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));
			Console.WriteLine("===== Speeding up =====");
			for (int i = 0; i < 7; i++)
				c1.Accelerate(20);
		}

		static void AsEvent()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Delegates as event enablers");

			Car c1 = new Car("SlugBug", 100, 10);

			c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
			Console.WriteLine("===== Speeding up =====");
			for (int i = 0; i < 7; i++)
				c1.Accelerate(20);
		}

		public static void OnCarEngineEvent(string msg)
		{
			Console.WriteLine("***** Message From Car Objec *****");
			Console.WriteLine($"=> {msg}");
			Console.WriteLine("**********************************");
		}

		public static void OnCarEngineEvent2(string msg)
		{
			ConsoleColor fore = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"-> {msg}");
			Console.ForegroundColor = fore;
		}
	}
}
