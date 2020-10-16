﻿using System;
using System.Linq;

namespace DefaultAppDomainApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Default AppDomain *****");
			DisplayDADStats();

			Console.ResetColor();
		}

		private static void DisplayDADStats() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Display DAD Stats");

			AppDomain defaultAD = AppDomain.CurrentDomain;

			Console.WriteLine($"Name of this domain: <{defaultAD.FriendlyName}>");
			Console.WriteLine($"ID of domain in this process: <{defaultAD.Id}>");
			Console.WriteLine($"Is this the default domain: <{defaultAD.IsDefaultAppDomain()}>");
			Console.WriteLine($"Basic directory of this domain: <{defaultAD.BaseDirectory}>");
			Console.WriteLine($"Configuration file of this domain: <{defaultAD.SetupInformation.ConfigurationFile}>");
			Console.WriteLine();

			Console.WriteLine($"The active thread ID in the current app domain: <{AppDomain.GetCurrentThreadId()}>");
			var s = defaultAD.GetAssemblies();
			Console.WriteLine($"-- assemblies (size {s.Count()})");
			foreach(var a in s)
				Console.WriteLine($"  <{a.FullName}> <{a.Location}>");
		}
	}
}