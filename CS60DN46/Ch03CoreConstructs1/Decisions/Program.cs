using System;

namespace Decisions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Decisions *****");
			SwitchOnString();
			Console.ResetColor();
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
