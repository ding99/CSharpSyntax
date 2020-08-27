using System;

namespace BasicInheritance
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Basic Inheritance *****");
			SimpleInheritance();
			Console.ResetColor();
		}

		static void SimpleInheritance()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> MiniVan inherite Car");

			Car car = new Car(80);
			car.Speed = 50;
			car.SetMax(90);
			Console.WriteLine($"The max speed of car is {car.maxSpeed}");
			Console.WriteLine($"The car is going {car.Speed} MPH");

			MiniVan van = new MiniVan();
			van.Speed = 30;
			van.SetMax(35);
			Console.WriteLine($"The max speed of van is {van.maxSpeed}");
			Console.WriteLine($"The van is going {van.Speed} MPH");
		}
	}
}
