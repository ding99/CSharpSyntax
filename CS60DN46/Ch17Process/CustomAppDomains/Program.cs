using System;
using System.IO;
using System.Linq;

namespace CustomAppDomains {
	class Program {
		static void Main() {
			Console.WriteLine("***** Create New Application Domain *****");
			CustomAppDomain();

			Console.ResetColor();
		}

		private static void CustomAppDomain() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Custom AppDomain");

			AppDomain defaultAD = AppDomain.CurrentDomain;
			ListAllAssembliesInAppDomain(defaultAD);

			//make a new AppDomain
			MakeNewAppDomain();
		}

		private static void MakeNewAppDomain() {
			string secondName = "SecondAppDomain";
			AppDomain newAD = AppDomain.CreateDomain(secondName);

			newAD.DomainUnload += (o, s) => {
				ConsoleColor color = Console.ForegroundColor;
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("The second AppDomain has been unloaded!");
				Console.ForegroundColor = color;
			};

			try { newAD.Load("CarLibrary"); }
			catch (FileNotFoundException e) { Console.WriteLine(e.Message); }

			ListAllAssembliesInAppDomain(newAD);
			AppDomain.Unload(newAD);
		}

		private static void ListAllAssembliesInAppDomain(AppDomain ad) {
			var loadedAssemblies = from a in ad.GetAssemblies() orderby a.GetName().Name select a;
			Console.WriteLine($"-- Here are the assemblies (size {loadedAssemblies.Count()}) loaded in {ad.FriendlyName}");
			foreach(var a in loadedAssemblies)
				Console.WriteLine($"   Name {a.GetName().Name}, Verison {a.GetName().Version}");
		}
	}
}
