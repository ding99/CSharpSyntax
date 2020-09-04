using System;
using System.Linq;

namespace LinqUsingEnumerable {
	class VeryComplexQueryStringsWithOperators {

		public static void QueryStringWithRawDelegates() {
			string[] games = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
			Console.Write($"-> Games (size {games.Count()}):");
			foreach (var g in games) Console.Write($" <{g}>");
			Console.WriteLine();

			Func<string, bool> searchFilter = new Func<string, bool>(Filter);
			Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);

			var subset = games.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

			Console.Write($"-> Containing Space (size {subset.Count()}):");
			foreach (var g in subset) Console.Write($" <{g}>");
			Console.WriteLine();
		}

		public static bool Filter(string game) { return game.Contains(" "); }
		public static string ProcessItem(string game) { return game; }
	}
}
