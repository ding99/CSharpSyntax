using System;

namespace SimpleCSharpApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("**** My First C# App *****");
			Console.WriteLine("Hello Core Constructure I!");
			Console.WriteLine();

			string[] theArgs = Environment.GetCommandLineArgs();
			foreach (string arg in theArgs)
				Console.WriteLine("Arg: {0}", arg);

			ShowEnvironmentDetails();
		}

		static void ShowEnvironmentDetails()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine("== Environment ==");
			foreach (string drive in Environment.GetLogicalDrives())
				Console.WriteLine("Drive: {0}", drive);

			Console.WriteLine("OS: {0}", Environment.OSVersion);
			Console.WriteLine("Number of processors: {0}",
				Environment.ProcessorCount);
			Console.WriteLine(".NET Version: {0}", Environment.Version);

			Console.ResetColor();
		}
	}
}
