using System;
using System.Linq;
using System.Reflection;

namespace DefaultAppDomainApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Default AppDomain *****");
			InitAD();
			DisplayDADStats();
			ListAllAssembliesInAppDomain();
			Console.ResetColor();
		}

		private static void InitAD() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Receive Assembly Load Notifications");

			AppDomain defaultAD = AppDomain.CurrentDomain;
			defaultAD.AssemblyLoad += (o, s) => Console.WriteLine($"<><><> {s.LoadedAssembly.GetName().Name} has been loaded!");
		}

		private static void ListAllAssembliesInAppDomain() {
			Console.ForegroundColor = ConsoleColor.Cyan;

			AppDomain defaultAD = AppDomain.CurrentDomain;

			Assembly[] loadedAssemblies = defaultAD.GetAssemblies();
			Console.WriteLine($"=> Here are the assemblies (size {loadedAssemblies.Count()}) loaded in {defaultAD.FriendlyName}");
			foreach (Assembly a in loadedAssemblies)
				Console.WriteLine($"{a.GetName().Name}, {a.GetName().Version} [{a.Location}]");

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			var sortedAssemblies = from a in defaultAD.GetAssemblies() orderby a.GetName().Name select a;
			Console.WriteLine($"=> Here are the sorted assemblies (size {sortedAssemblies.Count()}) loaded in {defaultAD.FriendlyName}");
			foreach (Assembly a in sortedAssemblies)
				Console.WriteLine($"{a.GetName().Name}, {a.GetName().Version} [{a.Location}]");
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

			Console.WriteLine($"The active thread ID in the current app domain: <{AppDomain.GetCurrentThreadId()}>");
		}
	}
}
