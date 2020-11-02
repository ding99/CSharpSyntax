using System;

namespace CStrings {
	class Types {
		public void ExamingTypes() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examine String/Char types");

			string s = "ABCDE";
			Console.WriteLine($"Type of s({s}): {s.GetType()}, Type of s[0]({s[0]}): {s[0].GetType()}");
		}
	}
}
