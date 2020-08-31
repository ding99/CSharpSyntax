using System;
using System.Collections.Generic;

namespace InterfaceExtensions {
	class Program {
		static void Main() {
			Console.WriteLine("***** Extending Types Implementing Specific Interface *****");
			ExtendInterface();
			Console.ResetColor();
		}

		static void ExtendInterface() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Entending Interface Compatible Types");

			string[] data = { "Wow", "this", "is", "sort", "of", "annoying", "but", "in", "a", "weird", "way", "fun!" };
			data.PrintDataAndBeep();
			Console.WriteLine();

			List<int> ints = new List<int> { 10, 15, 20 };
			ints.PrintDataAndBeep();
		}
	}
}
