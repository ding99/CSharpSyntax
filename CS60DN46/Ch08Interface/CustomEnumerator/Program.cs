using System;
using System.Collections;

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

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("-> use custom enumerator manually");
			IEnumerator enumerator = carLot.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Car car = (Car)enumerator.Current;
				Console.WriteLine($"{car.PetName} is going {car.CurrSpeed} MPH (M)");
			}
		}
	}
}
