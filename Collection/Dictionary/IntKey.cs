using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary {
	class IntKey {
		public IntKey() {
			Console.ForegroundColor = ConsoleColor.Cyan;
		}

		private void Method1(int[] input) {
			Console.Write($"input ({input.Length}):");
			foreach (int i in input) Console.Write($" {i}");
			Console.WriteLine();

			Dictionary<int, int> pair = new Dictionary<int, int>();
			foreach(int i in input) {
				if (pair.ContainsKey(i))
					pair[i]++;
				else pair.Add(i, 1);
			}

			int max = 0, key = -1;
			foreach(var a in pair) {
				if (a.Value > max) { max = a.Value; key = a.Key; }
			}

			Console.Write($"Dictionary ({pair.Count})");
			foreach (var a in pair) Console.Write($" {a.Key}-{a.Value}");
			Console.WriteLine();

			Console.WriteLine($"Pos:{key}, MaxValue:{max}");
		}

		private void Method2(int[] input) {

		}

		private void Analysis(string line1, string line2) {
			Console.WriteLine($"line1: [{line1}]");
			Console.WriteLine($"line2: [{line2}]");

			int count = 0;
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
		}

		public void Start() {
			Analysis("5", "1 2 2 3 1");
		}
	}
}
