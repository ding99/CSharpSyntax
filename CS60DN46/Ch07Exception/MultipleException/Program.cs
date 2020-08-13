using System;

namespace MultipleException
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Handling Multiple Exceptions *****");
			Multi();
			General();
			Console.ResetColor();
		}

		static void General()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> General Exception");
			Car car = new Car("Rusty", 80);
			try
			{
				car.Accelerate(80);
			}
			catch
			{
				Console.WriteLine("Something bad happened...");
			}
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
			catch (Exception e)
			{
				Console.WriteLine($"Exception: {e.Message}");
			}
		}
	}
}
