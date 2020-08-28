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

		/**
		 * A regular class may be inherited
		 * A virtual method in a regular class may be updated in the derived class.
		 */
		static void SimpleInheritance()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> MiniVan inherite Car");

			Car car = new Car();
			car.Speed = 50;
			car.SetMax(60);
			Console.WriteLine($"The max speed of car is {car.maxSpeed}");
			Console.WriteLine($"The car is going {car.Speed} MPH");

			MiniVan van = new MiniVan();
			van.Speed = 30;
			van.SetMax(60);
			Console.WriteLine($"The max speed of van is {van.maxSpeed}");
			Console.WriteLine($"The van is going {van.Speed} MPH");
		}
	}
}
