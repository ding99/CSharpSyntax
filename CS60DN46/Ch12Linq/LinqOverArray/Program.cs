using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverArray {
	class Program {
		static void Main() {
			Console.WriteLine("***** Linq to Object *****");
			QueryOverStrings();
			Console.ResetColor();
		}

		static void QueryOverStrings() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Query over strings");
			string[] games = { "Morrowwind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

			//query expression to find the items having an embedded space
			IEnumerable<string> subset = from g in games where g.Contains(" ") orderby g select g;
			foreach (string s in subset) Console.WriteLine($"Item: {s}");

			ReflectOverQueryResults(subset);
		}
		static void ReflectOverQueryResults(object resultSet) {
			Console.WriteLine("-> Info about your query");
			Console.WriteLine($"resultSet is of type: <{resultSet.GetType().Name}>, location: <{resultSet.GetType().Assembly.GetName().Name}>");
		}
	}
}
