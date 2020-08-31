using System;
using System.Reflection;

namespace ExtensionMethods {
	static class MyExtensions {
		//display he assembly
		public static void DisplayDefiningAssembly(this object obj) {
			Console.WriteLine($"{obj.GetType().Name} lives here: => {Assembly.GetAssembly(obj.GetType()).GetName().Name}");
		}

		//Reverse digits of any integer
		public static int ReverseDigits(this int i) {
			char[] digits = i.ToString().ToCharArray();
			Array.Reverse(digits);
			return int.Parse(new string(digits));
		}
	}
}
