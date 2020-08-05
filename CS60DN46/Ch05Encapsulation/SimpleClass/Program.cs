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
			Car car = new Car(); car.PrintState();
			car.name = "Henry"; car.speed = 50;
			for(int i = 0; i< 3; i++) { car.SpeedUp(5); car.PrintState(); }
		}
	}
}
