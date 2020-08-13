using System;

namespace SimpleException
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Simple Exception *****");
			CreatingCar();
			Console.ResetColor();
		}

		static void CreatingCar()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Creating a car and stepping on it!");
			Car car = new Car("Zippy", 20);
			car.CrankTunes(true);

			for (int i = 0; i < 10; i++)
				car.Accelerate(10);
		}
	}
}
