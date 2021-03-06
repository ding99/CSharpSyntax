﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverArray {
	class LinqBasedFieldsAreClunky {
		private static string[] games = { "Morrowwind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

		private IEnumerable<string> subset = from g in games where g.Contains(" ") orderby g select g;

		public void PrintGames() {
			Console.Write($"-> target (size {games.Length}):");
			foreach (var item in games)
				Console.Write($" <{item}>");
			Console.WriteLine();

			Console.Write($"-> subset (size {subset.Count()}):");
			foreach(var item in subset)
				Console.Write($" <{item}>");
			Console.WriteLine();
		}
	}
}
