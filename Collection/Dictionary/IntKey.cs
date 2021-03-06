﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary {
	class IntKey {
		public IntKey() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Integer Key (Some Assessment)");
		}

		private void ByDictionary(int[] input) {
			Console.WriteLine("-- Method 1: Dictionary");

			Dictionary<int, int> pair = new Dictionary<int, int>();
			foreach(int i in input)
				if (pair.ContainsKey(i))
					pair[i]++;
				else pair.Add(i, 1);

			int max = 0, pos = -1;
			foreach(var a in pair)
				if (a.Value > max) { max = a.Value; pos = a.Key; }

			Console.WriteLine($"max(loop): {max} at value {pos}");
			Console.WriteLine($"max(linq): {(from p in pair select p.Value).Max()}");
		}

		private void ByLinqQuery(int[] input) {
			Console.WriteLine("-- Method 2: Linq Query");

			var ndata = (from p in input.ToList() group p by p into g select new { key = g.Key, count = g.Count() });

			Console.Write($"ndata ({ndata.Count()}):");
			foreach (var a in ndata) Console.Write($" <{a.key}>-{a.count}");
			Console.WriteLine();

			Console.WriteLine($"max(linq): {ndata.Max(x => x.count)}");
		}
		private void ByLinqMethod(int[] input) {
			Console.WriteLine("-- Method 3: Linq Method");

			var ndata = input.ToList().GroupBy(x => x).Select(g => new { key = g.Key, count = g.Count() });

			Console.Write($"ndata ({ndata.Count()}):");
			foreach (var a in ndata) Console.Write($" <{a.key}>-{a.count}");
			Console.WriteLine();

			Console.WriteLine($"max(linq): {ndata.Max(x => x.count)}");
		}

		private void Analysis(string line1, string line2) {
			Console.WriteLine($"line1: [{line1}]");
			Console.WriteLine($"line2: [{line2}]");

			//int count;
			if (!Int32.TryParse(line1, out int count)) {
				Console.WriteLine("input line1 should be a number.");
				return;
			}

			string[] ns = line2.Split(' ');
			if(ns.Length != count) {
				Console.WriteLine($"The number of terms in line2 should equal to {count}");
				return;
			}

			int[] org = new int[count];
			for(int i = 0; i < count; i++)
				if(!Int32.TryParse(ns[i], out org[i])) {
					Console.WriteLine($"Term #{i + 1} in line2 should be a number");
					return;
				}

			ByDictionary(org);
			ByLinqQuery(org);
			ByLinqMethod(org);
		}

		public void Start() {
			Analysis("5", "1 2 2 3 1");
			Analysis("7", "1 2 2 3 1 5 2");
			Analysis("10", "1 2 2 3 1 5 2 3 3 3");
		}
	}
}
