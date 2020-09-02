using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverArray {
	class Program {
		static void Main() {
			Console.WriteLine("***** Linq to Object *****");
			QueryOverStrings();
			QueryOverInts();
			ImmediateExcution();
			ClassField();
			ReturnValues();
			Console.ResetColor();
		}

		static void ReturnValues() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Linq return values");

			IEnumerable<string> subset = GetStringSubset();
			Console.Write($"-> Returned subset (size {subset.Count()}):");
			foreach (string item in subset)
				Console.Write($" <{item}>");
			Console.WriteLine();

			string[] subsetArray = GetStringSubsetArray();
			Console.Write($"-> Returned subsetArray (size {subsetArray.Count()}):");
			foreach (string item in subsetArray)
				Console.Write($" <{item}>");
			Console.WriteLine();
		}

		static string[] GetStringSubsetArray() {
			string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

			Console.Write($"-> Original array (size {colors.Length}):");
			foreach (string s in colors) Console.Write($" <{s}>");
			Console.WriteLine();

			var reds = from c in colors where c.Contains("Red") select c;
			return reds.ToArray();
		}
		static IEnumerable<string> GetStringSubset() {
			string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

			Console.Write($"-> Original array (size {colors.Length}):");
			foreach (string s in colors) Console.Write($" <{s}>");
			Console.WriteLine();

			IEnumerable<string> reds = from c in colors where c.Contains("Red") select c;
			return reds;
		}

		static void ClassField() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Linq based fields are clunky");
			new LinqBasedFieldsAreClunky().PrintGames();
		}

		static void ImmediateExcution() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> The Role of Immediate Exection");
			int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

			Console.Write($"-> original array (size {numbers.Length}):");
			foreach (int a in numbers) Console.Write($" {a}");
			Console.WriteLine();

			int[] subsetArray = (from i in numbers where i < 10 select i).ToArray<int>();
			Console.Write($"-> subsetArray (size {subsetArray.Count()}):");
			foreach (int a in subsetArray) Console.Write($" {a}");
			Console.WriteLine();

			List<int> subsetList= (from i in numbers where i < 10 select i).ToList<int>();
			Console.Write($"-> subsetList (size {subsetList.Count()}):");
			foreach (int a in subsetList) Console.Write($" {a}");
			Console.WriteLine();

			numbers[0] = 4;
			List<int> subsetList2 = (from i in numbers where i < 10 select i).ToList<int>();
			Console.Write($"-> subsetList2 (size {subsetList2.Count()}):");
			foreach (int a in subsetList2) Console.Write($" {a}");
			Console.WriteLine();

			Console.Write($"-> subsetList (size {subsetList.Count()}):");
			foreach (int a in subsetList) Console.Write($" {a}");
			Console.WriteLine();
		}

		static void QueryOverInts() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Query over ints");
			int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

			Console.Write($"-> original array (size {numbers.Length}):");
			foreach (int a in numbers) Console.Write($" {a}");
			Console.WriteLine();

			IEnumerable<int> subset = from i in numbers where i < 10 select i;
			Console.Write($"-> subset (size {subset.Count()}):");
			foreach (int a in subset) Console.Write($" {a}");
			Console.WriteLine();
			ReflectOverQueryResults(subset);

			var subset2 = from i in numbers where i < 10 select i;
			Console.Write($"-> Implicit typing subset (size {subset2.Count()}):");
			foreach (var a in subset2) Console.Write($" {a}");
			Console.WriteLine();
			ReflectOverQueryResults(subset2);

			Console.WriteLine("=> The Role of Deferred Exection");
			numbers[0] = 4;

			Console.Write($"-> Implicit typing subset(Deferred) (size {subset2.Count()}):");
			foreach (var a in subset2) Console.Write($" {a}");
			Console.WriteLine();

			Console.Write($"-> subset(Deferred) (size {subset.Count()}):");
			foreach (int a in subset) Console.Write($" {a}");
			Console.WriteLine();
		}

		static void QueryOverStrings() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Query over strings");
			string[] games = { "Morrowwind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

			Console.WriteLine($"-> original array (size {games.Length}):");
			foreach (string s in games) Console.Write($" <{s}>");
			Console.WriteLine();

			//query expression to find the items having an embedded space
			IEnumerable<string> subset = from g in games where g.Contains(" ") orderby g select g;
			Console.WriteLine($"-> subset(containing an embedded space) (size {subset.Count()}):");
			foreach (string s in subset) Console.Write($" <{s}>");
			Console.WriteLine();

			ReflectOverQueryResults(subset);

			Console.WriteLine();
			Console.WriteLine("-> extension methods");
			//utility class extension methods
			Console.WriteLine($"Aggregate: <{games.Aggregate((one, two) => one + ", " + two)}>");		
			Console.WriteLine($"Max <{games.Max()}>, Min <{games.Min()}>, First <{games.First()}>, Last <{games.Last()}>");
		}

		static void ReflectOverQueryResults(object resultSet) {
			Console.WriteLine("-> Info about your query");
			Console.WriteLine($"resultSet is of type: <{resultSet.GetType().Name}>, location: <{resultSet.GetType().Assembly.GetName().Name}>");
		}
	}
}
