using System;
using System.Runtime.CompilerServices;

namespace SimpleClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Class Types *****");

			Speeding();
			ThisKeyword();

			Console.ResetColor();
		}

		static void ThisKeyword()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Motorcycle c = new Motorcycle(5);
			c.SetDriverName("Tiny");
			c.PopAWheely();
			Console.WriteLine($"Rider name is [{c.name}]");
		}

		static void Speeding()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			
			Car chunk = new Car(); chunk.PrintState();

			Car mary = new Car("Mary"); mary.PrintState();

			Car daisy = new Car("Daisy", 75); daisy.PrintState();

			Car car = new Car();  car.name = "Henry"; car.speed = 50;
			for(int i = 0; i< 3; i++) { car.SpeedUp(3); car.PrintState(); }
		}
	}
}
