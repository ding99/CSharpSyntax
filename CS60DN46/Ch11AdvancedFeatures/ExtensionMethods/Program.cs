using System;

namespace ExtensionMethods {
	class Program {
		static void Main() {
			Console.WriteLine("***** Extension Methods *****");
			InvokingExtension();
			Console.ResetColor();
		}

		static void InvokingExtension() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Invoking Extension Methods");

			int myInt = 12345678;
			myInt.DisplayDefiningAssembly();

			System.Data.DataSet d = new System.Data.DataSet();
			d.DisplayDefiningAssembly();

			System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
			sp.DisplayDefiningAssembly();

			Console.WriteLine($"Reversed digits of {myInt} is {myInt.ReverseDigits()}");
		}
	}
}
