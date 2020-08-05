using System;

namespace SimpleClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Class Types *****");

			Speeding();

			Console.ResetColor();
		}

		static void Speeding()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			
			Car chunk = new Car(); chunk.PrintState();

			Car mary = new Car("Mary"); mary.PrintState();

			Car daisy = new Car("Daisy", 75); daisy.PrintState();

			Car car = new Car();  car.name = "Henry"; car.speed = 50;
			for(int i = 0; i< 3; i++) { car.SpeedUp(5); car.PrintState(); }
		}
	}
}
