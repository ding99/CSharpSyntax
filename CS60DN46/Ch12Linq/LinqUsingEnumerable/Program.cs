using System;
using System.Linq;

namespace LinqUsingEnumerable {
	class Program {
		static void Main() {
			Console.WriteLine("***** Internal Representation *****");
			QueryStringWithOperators();
			QueryStringsWithEnumerableAndLambdas();
			QueryStringsWithEnumerableAndLambdas2();
			QueryStringsWithAnonymousMethods();
			Console.ResetColor();
		}

		static void QueryStringsWithAnonymousMethods() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Using anonymous Methods");

			string[] games = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
			Console.Write($"-> Games (size {games.Count()}):");
			foreach (var g in games) Console.Write($" <{g}>");
			Console.WriteLine();

			Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" "); };
			Func<string, string> itemToProcess = delegate (string s) { return s; };

			var subset = games.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

			Console.Write($"-> Containing Space (size {subset.Count()}):");
			foreach (var g in subset) Console.Write($" <{g}>");
			Console.WriteLine();
		}

		static void QueryStringsWithEnumerableAndLambdas2() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Using the Enumerabl / Lambda Expressioins 2");

			string[] games = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
			Console.Write($"-> Games (size {games.Count()}):");
			foreach (var g in games) Console.Write($" <{g}>");
			Console.WriteLine();

			var gamesWithSpace = games.Where(g => g.Contains(" "));
			var orderedGames = gamesWithSpace.OrderBy(g => g);
			var subset = orderedGames.Select(g => g);

			Console.Write($"-> Containing Space (size {subset.Count()}):");
			foreach (var g in subset) Console.Write($" <{g}>");
			Console.WriteLine();
		}

		static void QueryStringsWithEnumerableAndLambdas() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Using the Enumerabl / Lambda Expressioins");

			string[] games = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
			Console.Write($"-> Games (size {games.Count()}):");
			foreach (var g in games) Console.Write($" <{g}>");
			Console.WriteLine();

			var subset = games.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);

			Console.Write($"-> Containing Space (size {subset.Count()}):");
			foreach (var g in subset) Console.Write($" <{g}>");
			Console.WriteLine();
		}

		static void QueryStringWithOperators() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Using Query Operator");

			string[] games = { "Morrowind","Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
			Console.Write($"-> Games (size {games.Count()}):");
			foreach (var g in games) Console.Write($" <{g}>");
			Console.WriteLine();

			var subset = from g in games where g.Contains(" ") orderby g select g;

			Console.Write($"-> Containing Space (size {subset.Count()}):");
			foreach (var g in subset) Console.Write($" <{g}>");
			Console.WriteLine();
		}
	}
}
