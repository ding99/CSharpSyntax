using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace ExternalAssemblyReflector {
	class Program {
		static void Main() {
			Console.WriteLine("***** External Assembly Viewer *****");
			DisplayTypes();
			Console.ResetColor();
		}

		static void DisplayTypes() {
			Console.ForegroundColor = ConsoleColor.Yellow;

			string asmName = "";
			do {
				Console.Write("Enter an assembly to evaluate or Q to quit:");
				asmName = Console.ReadLine();

				if (asmName.ToUpper().Equals("Q")) break;

				try {
					DisplayTypesInAsm(Assembly.Load(asmName));
				}
				catch(Exception e) {
					Console.WriteLine($"Sorry, can't find assembly. {e.Message}");
				}
			} while (true);
		}

		static void DisplayTypesInAsm(Assembly asm) {
			Console.WriteLine($"-> Types in Assembly <{asm.FullName}>");
			Type[] types = asm.GetTypes();
			Console.Write($"Types:");
			foreach (Type t in types)
				Console.Write($" <{t}>");
			Console.WriteLine();
		}
	}
}
