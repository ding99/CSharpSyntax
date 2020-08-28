using System;

namespace CarDelegateMethodGroupConversion
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Method Group Conversion *****");
			Group();
			Console.ResetColor();
		}

		static void Group()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Method Group Conversion");

			Car c1 = new Car("SlugBug", 100, 10);

			c1.RegisterWithCarEngine(CallMeHere);
			Console.WriteLine("===== Speeding up =====");
			for (int i = 0; i < 7; i++)
				c1.Accelerate(20);

			c1.UnRegisterWithCarEngine(CallMeHere);
			c1.Speed = 10;
			c1.StatusReset();
			Console.WriteLine("----- Speeding up -----");
			for (int i = 0; i < 7; i++)
				c1.Accelerate(20);
		}

		static void CallMeHere(string msg)
		{
			Console.WriteLine($"-> Message from Car: <{msg}>");
		}
	}
}
