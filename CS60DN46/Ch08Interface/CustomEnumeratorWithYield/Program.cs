using System;

namespace CustomEnumeratorWithYield
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Custom Enumerator with Yield *****");
			WithYield();
			Console.ResetColor();
		}

		static void WithYield()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> compare with named iterator");

			Garage carLot = new Garage();
			foreach(Car c in carLot)
				Console.WriteLine($"{c.PetName} is going {c.CurrSpeed} MPH");

			Console.WriteLine("-> using GetTheCars");
			foreach(Car c in carLot.GetTheCars(true))
				Console.WriteLine($"{c.PetName} is going {c.CurrSpeed} MPH");
		}
	}
}
