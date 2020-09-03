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

			IEnumerable<string> excellence2 = from score in scores where score > 80 orderby score select $"The score is {score}";
			Console.Write($"Excellent (size {excellence2.Count()}):");
			foreach (var a in excellence2) Console.Write($" <{a}>");
			Console.WriteLine();
		}
	}
}
