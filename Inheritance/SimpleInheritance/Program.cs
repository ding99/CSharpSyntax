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
			Console.WriteLine($"The max speed of car is {car.maxSpeed}");
			Console.WriteLine($"The car is going {car.Speed} MPH");
		}
	}
}
