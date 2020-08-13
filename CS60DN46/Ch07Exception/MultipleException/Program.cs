using System;

namespace MultipleException
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Handling Multiple Exceptions *****");
			Multi();
			Console.ResetColor();
		}

		static void Multi()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Multiple Exception");

			Car car = new Car("Rushy", 90);
			try
			{
				car.Accelerate(-10);
			}
			catch (CarIsDeadException e)
			{
				Console.WriteLine($"Car Is Dead Exception: {e.Message}");
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine($"Argument Out Of Range Exception: {e.Message}");
			}
		}
	}
}
