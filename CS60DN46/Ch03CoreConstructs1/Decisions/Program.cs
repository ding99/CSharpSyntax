using System;

namespace Decisions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Decisions *****");
			SwitchOnString();
			SwitchOnEnum();
			Console.ResetColor();
		}

		static void SwitchOnEnum()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Enter your favorite day of the week: ");
			DayOfWeek day;

			try
			{
				day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("Bad input!");
				return;
			}

			switch (day)
			{
				case DayOfWeek.Friday:
					Console.WriteLine("Yes, Friday rules!");
					break;
				case DayOfWeek.Monday:
					Console.WriteLine("Another day, another dollar");
					break;
				case DayOfWeek.Saturday:
					Console.WriteLine("Great day indeed.");
					break;
				case DayOfWeek.Sunday:
					Console.WriteLine("Football!!");
					break;
				case DayOfWeek.Thursday:
					Console.WriteLine("Almost Friday...");
					break;
				case DayOfWeek.Tuesday:
					Console.WriteLine("At least it is not Monday");
					break;
				case DayOfWeek.Wednesday:
					Console.WriteLine("A fine day.");
					break;
			}
		}

		static void SwitchOnString()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("C# or VB");
			Console.Write("Please pick your language preference: ");

			string lang = Console.ReadLine();
			switch (lang)
			{
				case "#C":
					Console.WriteLine("Good choice, C# is a fine language.");
					break;
				case "VB":
					Console.WriteLine("VB: OOP, multithreading and more!");
					break;
				default:
					Console.WriteLine("Well... good luck with that!");
					break;
			}
		}
	}
}
