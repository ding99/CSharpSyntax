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
			Console.WriteLine($"My car is going {car.Speed} MPH, max is {car.maxSpeed}.");
			car.CurrSpeed();

			MiniVan van = new MiniVan();
			van.Speed = 10;
			Console.WriteLine($"My van is going {van.Speed} MPH, max is {van.maxSpeed}.");
			van.CurrSpeed();

			SpecVan spec = new SpecVan();
			spec.Speed = 25;
			Console.WriteLine($"My spec van is going {spec.Speed} MPH, max is {spec.maxSpeed}.");
			spec.CurrSpeed();
		}
	}
}
