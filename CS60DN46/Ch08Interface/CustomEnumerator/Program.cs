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
			EnumeratorsYield();
			Console.ResetColor();
		}

		static void EnumeratorsYield()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> custom enumerator with yield");

			Garage2 carLot = new Garage2();
			foreach (Car c in carLot)
				Console.WriteLine($"{c.PetName} is going {c.CurrSpeed} MPH");
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
				Car c = (Car)enumerator.Current;
				Console.WriteLine($"{c.PetName} is going {c.CurrSpeed} MPH (M)");
			}
		}

		/** result:
		***** IEnumerable and IEnumerator *****
		=> custom enumerator
		Rusty is going 30 MPH
		Clunker is going 55 MPH
		Zippy is going 30 MPH
		Fred is going 30 MPH
		-> use custom enumerator manually
		Rusty is going 30 MPH (M)
		Clunker is going 55 MPH (M)
		Zippy is going 30 MPH (M)
		Fred is going 30 MPH (M)
		=> custom enumerator with yield
		Rusty2 is going 30 MPH
		Clunker2 is going 55 MPH
		Zippy2 is going 30 MPH
		Fred2 is going 30 MPH
		**/
	}
}
