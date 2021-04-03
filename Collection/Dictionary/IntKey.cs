using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary {
	class IntKey {
		public IntKey() {
			Console.ForegroundColor = ConsoleColor.Cyan;
		}

		private void Method1(int[] input) {
			Console.WriteLine("-- Method 1: Dictionary");

			Dictionary<int, int> pair = new Dictionary<int, int>();
			foreach(int i in input) {
				if (pair.ContainsKey(i))
					pair[i]++;
				else pair.Add(i, 1);
			}

			int max = 0, pos = -1;
			foreach(var a in pair) {
				if (a.Value > max) { max = a.Value; pos = a.Key; }
			}

			Console.WriteLine($"max(loop): {max} at value {pos}");

			Console.WriteLine($"max(linq): {(from p in pair select p.Value).Max()}");
		}

		private void Method2(int[] input) {
			Console.WriteLine("-- Method 2: Linq");

			List<int> data = input.ToList();
			var max = (from p in input.ToList() group p by p into g select new { key = g.Key, count = g.Count() }).Max(x => x.count);
			Console.WriteLine($"max(linq): {max}");
		}

		private void Analysis(string line1, string line2) {
			Console.WriteLine($"line1: [{line1}]");
			Console.WriteLine($"line2: [{line2}]");

			int count;
			if (!Int32.TryParse(line1, out count)) {
				Console.WriteLine("input line1 should be a number.");
				return;
			}

			string[] ns = line2.Split(' ');
			if(ns.Length != count) {
				Console.WriteLine($"The number of terms in line2 should equal to {count}");
				return;
			}

			int[] org = new int[count];
			for(int i = 0; i < count; i++) {
				if(!Int32.TryParse(ns[i], out org[i])) {
					Console.WriteLine($"Term #{i + 1} in line2 should be a number");
					return;
				}
			}

			Method1(org);
			Method2(org);
		}

		public void Start() {
			Analysis("5", "1 2 2 3 1");
			Analysis("7", "1 2 2 3 1 5 2");
			Analysis("10", "1 2 2 3 1 5 2 3 3 3");
		}
	}
}
