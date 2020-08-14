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
			ReThrow();
			Console.ResetColor();
		}

		static void ReThrow()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> ReThrow Exception");

			try
			{
				FirstThrow();
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine($"Argument Out Of Range Exception: {e.Message}");
			}
			catch (Exception e)
			{
				Console.WriteLine($"Exception(Re): {e.Message}");
				throw;
			}
		}

		static void FirstThrow()
		{
			Car car = new Car("Rushy", 70);
			try
			{
				car.Accelerate(-20);
			}
			catch (Exception e)
			{
				Console.WriteLine($"Exception: {e.Message}");
				throw;
			}
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
			car.CrankTunes(true);

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
			finally
			{
				car.CrankTunes(false);
			}
		}
	}
}
