using System;

namespace BasicInheritance
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Basic Inheritance *****");
			Basic();
			Console.ResetColor();
		}

		static void Basic()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Car car = new Car(80);

			car.Speed = 50;
			Console.WriteLine($"My car is going {car.Speed} MPH");
		}
	}
}
