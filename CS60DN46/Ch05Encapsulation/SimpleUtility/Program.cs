using System;
using static System.Console;
using static SimpleUtility.TimeUtil;

namespace SimpleUtility
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("***** Static Classes *****");
			TimeAndDate();
			ResetColor();
		}

		static void TimeAndDate()
		{
			ForegroundColor = ConsoleColor.Green;

			PrintDate();
			PrintTime();
		}
	}
}
