using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SharedAsmReflector {
	class Program {
		static void Main() {
			Console.WriteLine("***** Shared Assemblies *****");
			AsmReflector();
			Console.ResetColor();
		}

		static void AsmReflector() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> The Shared Asm Reflector App");

			//Load System.Windows.Forms.dll from GAC.
			StringBuilder name = new StringBuilder("System.Windows.Forms,");
			name.Append("Version=4.0.0.0,");
			name.Append("PublicKeyToken=b77a5c561934e089,");
			name.Append(@"Culture=""");

			Assembly asm = Assembly.Load(name.ToString());
			DisplayInfo(asm);
			Console.WriteLine("Done");
		}

		static void DisplayInfo(Assembly a) {
			Console.WriteLine($"=> Infor about Assembly.");
			Console.WriteLine($"Loaded from GAC? {a.GlobalAssemblyCache}");
			Console.WriteLine($"Asm Name   : {a.GetName().Name}");
			Console.WriteLine($"Asm Version: {a.GetName().Version}");
			Console.WriteLine($"Asm Culture: {a.GetName().CultureInfo.DisplayName}");
			
			Type[] types = a.GetTypes();
			var publicEnums = from pe in types where pe.IsEnum && pe.IsPublic select pe;
			Console.Write($"Here are the public enums (size {publicEnums.Count()}):");
			foreach (var pe in publicEnums)
				Console.Write($" <{pe}>");
			Console.WriteLine();
		}
	}
}
