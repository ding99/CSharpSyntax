using System;

namespace SimpleCSharpApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Core C# Programming Constructs, Part I";

			Console.WriteLine("**** My First C# App *****");
			Console.WriteLine("Hello Core Constructure I!");
			Console.WriteLine();

			string[] theArgs = Environment.GetCommandLineArgs();
			Console.WriteLine("Number of arguments: {0}", theArgs.Length);
			foreach (string arg in theArgs)
				Console.WriteLine("Arg: {0}", arg);
			Console.WriteLine();

			ShowEnvironmentDetails();

			Console.WriteLine();
			Console.Beep();
			Console.WriteLine("Windows: Top {0} x Left {1} Size: {2} x {3}",
				Console.WindowTop, Console.WindowLeft, Console.WindowWidth, Console.WindowHeight);
			Console.WriteLine("Buffer area: {0} x {1}",
				Console.BufferWidth, Console.BufferHeight);
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

			Console.WriteLine();
			Console.WriteLine("Is64BitOperationSystem: {0}", Environment.Is64BitOperatingSystem);
			Console.WriteLine("Is64BitProcess: {0}", Environment.Is64BitProcess);
			Console.WriteLine("MachineName: {0}", Environment.MachineName);
			Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);
			Console.WriteLine("UserName: {0}", Environment.UserName);
			Console.WriteLine("ExitCode: {0}", Environment.ExitCode);

			Console.ResetColor();
		}
	}
}
