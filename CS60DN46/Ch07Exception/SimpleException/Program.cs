using System;
using System.Collections;

namespace SimpleException
{
	class Program
	{
		static void Main()
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

			try
			{
				for (int i = 0; i < 10; i++)
					car.Accelerate(10);
			}
			catch(Exception e)
			{
				Console.WriteLine("--- Error! ---");
				Console.WriteLine($"Method: {e.TargetSite}");
				Console.WriteLine($"Message: {e.Message}");
				Console.WriteLine($"Source: {e.Source}");
				Console.WriteLine($"Data: <{e.Data.Count}>; Keys: <{e.Data.Keys.Count}>");
				Console.WriteLine($"StackTrace: <{e.StackTrace}>");
				Console.WriteLine($"HelpLink: <{e.HelpLink}>");
				Console.WriteLine($"-> Member name: {e.TargetSite}");
				Console.WriteLine($"Member type: {e.TargetSite.MemberType}");
				Console.WriteLine($"Reflected type: {e.TargetSite.ReflectedType}");
				Console.WriteLine($"Class defining member: {e.TargetSite.DeclaringType}");
			}

			Console.WriteLine("----- Out of exception logic -----");
		}
	}
}
