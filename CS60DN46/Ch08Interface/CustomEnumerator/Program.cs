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
		**/
	}
}
