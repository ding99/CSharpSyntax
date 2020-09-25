using System;
using System.Reflection;

namespace ExternalAssemblyReflector {
	class Program {
		static void Main() {
			Console.WriteLine("***** External Assembly Viewer *****");
			ByLoad();
			ByLoadFrom();
			Console.ResetColor();
		}

		//test data: d:\workFolder\CarLibs\version2.0\CarLibrary.dll
		static void ByLoadFrom() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Disply Types using Assembly.LoadFrom()");

			string asmName = "";
			do {
				Console.Write("Enter an assembly to evaluate or Q to quit:");
				asmName = Console.ReadLine();

				if (asmName.ToUpper().Equals("Q")) break;

				try {
					DisplayTypesInAsm(Assembly.LoadFrom(asmName));
				}
				catch (Exception e) {
					Console.WriteLine($"Sorry, can't find assembly. {e.Message}");
				}
			} while (true);
		}

		static void ByLoad() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Disply Types using Assembly.Load()");

			string asmName = "";
			do {
				Console.Write("Enter an assembly to evaluate or Q to quit:");
				asmName = Console.ReadLine();

				if (asmName.ToUpper().Equals("Q")) break;

				try {
					DisplayTypesInAsm(Assembly.Load(asmName));
					//Assembly.LoadFrom(asmName) for absolute path
				}
				catch (Exception e) {
					Console.WriteLine($"Sorry, can't find assembly. {e.Message}");
				}
			} while (true);
		}

		static void DisplayTypesInAsm(Assembly asm) {
			Console.WriteLine($"-> Types in Assembly <{asm.FullName}>");
			Type[] types = asm.GetTypes();
			foreach (Type t in types)
				Console.WriteLine($"Type: <{t}>");
		}
	}
}
