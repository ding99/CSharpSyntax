using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CustomAppDomains {
	class Program {
		static void Main() {
			Console.WriteLine("***** Create New Application Domain *****");
			CustomAppDomain();

			Console.ResetColor();
			Console.ReadLine();
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
			ListAllAssembliesInAppDomain(newAD);
		}

		private static void ListAllAssembliesInAppDomain(AppDomain ad) {
			var loadedAssemblies = from a in ad.GetAssemblies() orderby a.GetName().Name select a;
			Console.WriteLine($"-- Here are the assemblies (size {loadedAssemblies.Count()}) loaded in {ad.FriendlyName}");
			foreach(var a in loadedAssemblies)
				Console.WriteLine($"   Name {a.GetName().Name}, Verison {a.GetName().Version}");
		}
	}
}
