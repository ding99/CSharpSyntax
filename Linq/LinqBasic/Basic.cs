using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasic {
	class Basic {
		int[] scores;

		public Basic() {
			scores = new int[] { 97, 55, 61, 81, 92 };
			Console.Write($"Original  (size {scores.Count()}):");
			foreach (var a in scores) Console.Write($" <{a}>");
			Console.WriteLine();
		}

		public void Start() {
			Console.ForegroundColor = ConsoleColor.Yellow; Select();
		}

		public void Select() {
			Console.WriteLine("- Select");
			IEnumerable<int> excellence = from score in scores where score > 80 orderby score select score;
			Console.Write($"Excellent (size {excellence.Count()}):");
			foreach (var a in excellence) Console.Write($" <{a}>");
			Console.WriteLine();

			var excellence2 = from score in scores where score > 80 orderby score descending select $"The score is {score}";
			Console.Write($"Excellent (size {excellence2.Count()}):");
			foreach (var a in excellence2) Console.Write($" <{a}>");
			Console.WriteLine();

			int n = 1;
			var passed = (from score in scores where score > 60 orderby score descending select new { Number = n++, Score = score }).ToList();
			Console.Write($"Passed (size {passed.Count()}):");
			foreach (var a in passed) Console.Write($" <{a.Number}-{a.Score}>");
			Console.WriteLine();
		}
	}
}
