using System;

namespace CustomException
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Custom Exception *****");
			Custom1();
			Console.ResetColor();
		}

		static void Custom1()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Custom Exception Take 1");

			Car car = new Car("Rusty", 90);
			try
			{
				car.Accelerate(50);
			}
			catch(CarIsDeadException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.ErrorTimeStamp);
				Console.WriteLine(e.CauseOfError);
			}
		}
	}
}
