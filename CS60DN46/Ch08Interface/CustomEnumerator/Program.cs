using System;

namespace CustomEnumerator
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** IEnumerable and IEnumerator *****");
			Enumerators();
			Console.ResetColor();
		}

		static void Enumerators()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> custom enumerator");

			Garage carLot = new Garage();
			foreach(Car c in carLot)
				Console.WriteLine($"{c.PetName} is going {c.CurrSpeed} MPH");
		}
	}
}
