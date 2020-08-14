using System;

namespace CustomException
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Custom Exception *****");
			Custom1();
			Custom2When();
			CustomBest();
			Console.ResetColor();
		}

		static void CustomBest()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Custom Exception Take 3, Best");

			Car car = new Car("Rushy", 90);
			try
			{
				car.AccelerateBest(50);
			}
			catch (CarIsDeadExceptionBest e)
			{
				Console.WriteLine(e.Message);
			}
		}

		static void Custom2When()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Custom Exception Take 2");

			Car car = new Car("Rushy", 90);
			try
			{
				car.Accelerate2(50);
			}
			catch (CarIsDeadException2 e) when (e.ErrorTimeStamp.DayOfWeek == DayOfWeek.Friday)
			{
				Console.WriteLine($"CarIsDead Exceptiong: {e.Message}");
				Console.WriteLine(e.ErrorTimeStamp);
				Console.WriteLine(e.CauseOfError);
			}
			catch(Exception e)
			{
				Console.WriteLine($"Exception: {e.Message}");
			}
		}

		static void Custom1()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Custom Exception Take 1");

			Car car = new Car("Rusty", 90);
			try
			{
				car.Accelerate1(50);
			}
			catch(CarIsDeadException1 e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.ErrorTimeStamp);
				Console.WriteLine(e.CauseOfError);
			}
		}
	}
}
