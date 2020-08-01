using System;

namespace DateAndTime
{
	class Program
	{
		static void Main(string[] args)
		{
			UseDatesAndTimes();
		}

		static void UseDatesAndTimes()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("=> Dates and Times:");
			DateTime dt = new DateTime(2015, 10, 17);
			Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
			dt = dt.AddMonths(2);
			Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

			TimeSpan ts = new TimeSpan(25, 30, 0);
			Console.WriteLine(ts);
			Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
			Console.WriteLine();

			Console.ResetColor();
		}
	}
}
